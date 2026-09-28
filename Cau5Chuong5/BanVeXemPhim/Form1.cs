namespace BanVeXemPhim
{
    public partial class FormBanVe : Form
    {
        public FormBanVe()
        {
            InitializeComponent();
        }
        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            using (FormChonGhe dlg = new FormChonGhe(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text) ||
                cboPhim.SelectedIndex == -1 ||
                cboSuatChieu.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin và chọn ghế trước khi đặt vé!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string thongTin = $"Tên khách: {txtTenKhach.Text}\n" +
                              $"Phim: {cboPhim.SelectedItem}\n" +
                              $"Suất chiếu: {cboSuatChieu.SelectedItem}\n" +
                              $"Ghế: {txtGheDaChon.Text}\n" +
                              $"Giá vé: 75.000đ/vé";

            MessageBox.Show(thongTin, "Xác nhận đặt vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
