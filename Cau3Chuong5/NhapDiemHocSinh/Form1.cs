using System;
using System.Windows.Forms;

namespace NhapDiemHocSinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DangKyEnterChuyenField();

            txtToan.Enter += TextBoxDiem_Enter;
            txtVan.Enter += TextBoxDiem_Enter;
            txtAnh.Enter += TextBoxDiem_Enter;
        }

        private void DangKyEnterChuyenField()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.KeyPress += (sender, e) =>
                    {
                        if (e.KeyChar == (char)Keys.Enter)
                        {
                            e.Handled = true;


                            if (txt.Name == "txtAnh")
                            {
                                btnLuu.PerformClick();
                            }
                            else
                            {
                                this.SelectNextControl((Control)sender, true, true, true, true);
                            }
                        }
                    };
                }
            }
        }

        private void TextBoxDiem_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.SelectAll();
            }
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hopLe = true;
            decimal diemToan, diemVan, diemAnh;

            if (!decimal.TryParse(txtToan.Text, out diemToan) || diemToan < 0.0m || diemToan > 10.0m)
            {
                errorProvider1.SetError(txtToan, "Điểm Toán không hợp lệ.");
                hopLe = false;
            }

            if (!decimal.TryParse(txtVan.Text, out diemVan) || diemVan < 0.0m || diemVan > 10.0m)
            {
                errorProvider1.SetError(txtVan, "Điểm Văn không hợp lệ.");
                hopLe = false;
            }

            if (!decimal.TryParse(txtAnh.Text, out diemAnh) || diemAnh < 0.0m || diemAnh > 10.0m)
            {
                errorProvider1.SetError(txtAnh, "Điểm Anh không hợp lệ.");
                hopLe = false;
            }


            if (hopLe)
            {
                string thongTin = $"{txtMaHS.Text} | {txtHoTen.Text} | T:{diemToan} V:{diemVan} A:{diemAnh}";
                lstDanhSach.Items.Add(thongTin);

                txtMaHS.Clear();
                txtHoTen.Clear();
                txtToan.Clear();
                txtVan.Clear();
                txtAnh.Clear();

                txtMaHS.Focus();
            }
        }
    }
}