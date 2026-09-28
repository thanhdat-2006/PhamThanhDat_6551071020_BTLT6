using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace DatPhongKhachSan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox_Validated(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                tb.BackColor = Color.Honeydew;
            }
        }

        private void txtHoTen_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống.");
                txtHoTen.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }
        }

        private void txtCCCD_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtCCCD.Text.Length != 12 || !txtCCCD.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCCCD, "CCCD phải đúng 12 chữ số.");
                txtCCCD.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtCCCD, "");
            }
        }

        private void txtNgayNhan_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime ngayNhan;
            bool isParsed = DateTime.TryParseExact(txtNgayNhan.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out ngayNhan);

            if (!isParsed || ngayNhan.Date < DateTime.Today)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayNhan, "Ngày nhận phải đúng định dạng dd/MM/yyyy và >= hôm nay.");
                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtNgayNhan, "");
            }
        }

        private void txtNgayTra_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime ngayTra;
            DateTime ngayNhan;
            bool isNgayTraParsed = DateTime.TryParseExact(txtNgayTra.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out ngayTra);
            DateTime.TryParseExact(txtNgayNhan.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out ngayNhan); // Lấy ngày nhận để so sánh

            if (!isNgayTraParsed || ngayTra.Date <= ngayNhan.Date)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayTra, "Ngày trả phải hợp lệ và lớn hơn ngày nhận."); // Báo lỗi ngay khi rời txtNgayTra[cite: 2]
                txtNgayTra.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtNgayTra, "");
            }
        }

        private void txtSoNguoiLon_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int soNguoiLon;
            if (!int.TryParse(txtSoNguoiLon.Text, out soNguoiLon) || soNguoiLon < 1 || soNguoiLon > 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoNguoiLon, "Số người lớn phải từ 1 đến 4.");
                txtSoNguoiLon.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoNguoiLon, "");
            }
        }

        private void txtSoTreEm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int soTreEm;
            if (!int.TryParse(txtSoTreEm.Text, out soTreEm) || soTreEm < 0 || soTreEm > 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoTreEm, "Số trẻ em phải từ 0 đến 3.");
                txtSoTreEm.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoTreEm, "");
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                // Khi hợp lệ, tính số đêm[cite: 2]
                DateTime ngayNhan = DateTime.ParseExact(txtNgayNhan.Text, "dd/MM/yyyy", null);
                DateTime ngayTra = DateTime.ParseExact(txtNgayTra.Text, "dd/MM/yyyy", null);
                int soDem = (ngayTra - ngayNhan).Days;

                // Hiện MessageBox thông báo[cite: 2]
                string thongTin = $"Khách hàng: {txtHoTen.Text}\n" +
                                  $"Số đêm: {soDem}\n" +
                                  $"Người lớn: {txtSoNguoiLon.Text}, Trẻ em: {txtSoTreEm.Text}";

                MessageBox.Show(thongTin, "Đặt phòng thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
