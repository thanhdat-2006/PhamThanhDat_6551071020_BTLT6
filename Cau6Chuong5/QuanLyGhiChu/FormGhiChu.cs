using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyGhiChu
{
    public partial class FormGhiChu : Form
    {
        private bool daThayDoi = false;
        public FormGhiChu()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            daThayDoi = true;
        }

        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnLuuGhiChu.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (daThayDoi)
                {
                    if (MessageBox.Show("Nội dung chưa lưu. Bạn có chắc muốn đóng?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNoiDung.Text.Length >= 500 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void lblTieuDeForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnLuuGhiChu_MouseEnter(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.LightSkyBlue;
        }

        private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = SystemColors.Control;
        }

        private void txtTieuDe_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTieuDe.Text) || txtTieuDe.Text.Length > 50)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được để trống và tối đa 50 ký tự.");
                txtTieuDe.BackColor = Color.MistyRose;
            }
        }

        private void txtTieuDe_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTieuDe, "");
            txtTieuDe.BackColor = Color.White;
        }

        private void btnLuuGhiChu_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            // Lưu thành công
            this.Text = txtTieuDe.Text;
            daThayDoi = false;
            MessageBox.Show("Đã lưu ghi chú", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
