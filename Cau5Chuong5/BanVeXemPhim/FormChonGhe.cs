using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BanVeXemPhim
{
    public partial class FormChonGhe : Form
    {
        public string GheChon { get; private set; }
        public FormChonGhe(string gheHienTai)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(gheHienTai) && lstGhe.Items.Contains(gheHienTai))
            {
                lstGhe.SelectedItem = gheHienTai;
            }
        }

        private void lstGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem != null)
            {
                lblGheDaChon.Text = "Đang chọn: " + lstGhe.SelectedItem.ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (lstGhe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một ghế!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GheChon = lstGhe.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
