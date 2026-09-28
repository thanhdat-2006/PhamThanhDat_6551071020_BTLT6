namespace UngDungGiaoDoAn
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private bool KiemTraHopLe()
        {
            bool isValid = true;
            if (String.IsNullOrWhiteSpace(txtHoTen.Text) || txtHoTen.Text.Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống và tổi thiểu 3 ký tự.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            if (String.IsNullOrWhiteSpace(txtSDT.Text) || txtSDT.Text.Length != 10 || !txtSDT.Text.StartsWith("0") || !txtSDT.Text.All(char.IsDigit))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải đúng 10 ký tự và bắt đầu bằng số 0.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            int atIndex = txtEmail.Text.IndexOf("@");
            int dotIndex = txtEmail.Text.IndexOf(".", atIndex + 1);
            if (atIndex == -1 || dotIndex == -1)
            {
                errorProvider1.SetError(txtEmail, "Email phải chứa '@' và có dấu '.' phía sau '@'.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            if (String.IsNullOrWhiteSpace(txtMatKhau.Text) || txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải tối thiểu 6 ký tự.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            if (String.IsNullOrWhiteSpace(txtXacNhanMK.Text) || txtXacNhanMK.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(txtXacNhanMK, "Mật khẩu không trùng khớp.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return isValid;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show("Đăng ký thành công! Chào mừng " + txtHoTen.Text,
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;

            errorProvider1.Clear();

            this.Close();
        }
    }
}
