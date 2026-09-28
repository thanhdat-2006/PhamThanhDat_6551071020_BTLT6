namespace QuanLyDanhBa
{
    public partial class frmDanhBa : Form
    {
        private int indexDangSua = -1;
        public frmDanhBa()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.FormDanhBa_FormClosing);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string lienHe = $"{txtTen.Text} - {txtSDT.Text}";

            if (indexDangSua == -1)
            {
                lstLienHe.Items.Add(lienHe);
                MessageBox.Show("Thêm thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lstLienHe.Items[indexDangSua] = lienHe;
                MessageBox.Show("Cập nhật thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                indexDangSua = -1;
            }

            txtTen.Clear();
            txtSDT.Clear();
            txtTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            indexDangSua = lstLienHe.SelectedIndex;
            string[] thongTin = lstLienHe.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.None);

            if (thongTin.Length == 2)
            {
                txtTen.Text = thongTin[0];
                txtSDT.Text = thongTin[1];
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenLienHe = lstLienHe.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.None)[0];

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa liên hệ {tenLienHe}? Thao tác này không thể hoàn tác!",
                                                  "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(lstLienHe.SelectedIndex);
                MessageBox.Show("Xóa thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (indexDangSua != -1)
                {
                    indexDangSua = -1;
                    txtTen.Clear();
                    txtSDT.Clear();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text) || !string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                DialogResult result = MessageBox.Show("Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                                                      "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (result == DialogResult.No)
                {
                    txtTen.Clear();
                    txtSDT.Clear();
                }
            }
        }
    }
}
