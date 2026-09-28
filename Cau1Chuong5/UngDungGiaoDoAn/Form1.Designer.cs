namespace UngDungGiaoDoAn
{
    partial class frmDangKy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            lblHoTen = new Label();
            lblSDT = new Label();
            lblEmail = new Label();
            lblMatKhau = new Label();
            lblXacNhanMK = new Label();
            txtHoTen = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMK = new TextBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(337, 41);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký tài khoản mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(13, 50);
            label2.Name = "label2";
            label2.Size = new Size(285, 28);
            label2.TabIndex = 1;
            label2.Text = "Vui lòng nhập đầy đủ thông tin";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(239, 165);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(66, 25);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(188, 228);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(117, 25);
            lblSDT.TabIndex = 3;
            lblSDT.Text = "Số điện thoại";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(244, 305);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(219, 371);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(86, 25);
            lblMatKhau.TabIndex = 5;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblXacNhanMK
            // 
            lblXacNhanMK.AutoSize = true;
            lblXacNhanMK.Location = new Point(142, 449);
            lblXacNhanMK.Name = "lblXacNhanMK";
            lblXacNhanMK.Size = new Size(163, 25);
            lblXacNhanMK.TabIndex = 6;
            lblXacNhanMK.Text = "Xác nhận mật khẩu";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(330, 162);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(435, 31);
            txtHoTen.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(330, 302);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(435, 31);
            txtEmail.TabIndex = 8;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(330, 225);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(435, 31);
            txtSDT.TabIndex = 9;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(330, 368);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(435, 31);
            txtMatKhau.TabIndex = 10;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(330, 449);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(435, 31);
            txtXacNhanMK.TabIndex = 11;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = SystemColors.Highlight;
            btnDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDangKy.ForeColor = SystemColors.ButtonHighlight;
            btnDangKy.Location = new Point(359, 526);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(112, 34);
            btnDangKy.TabIndex = 12;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = SystemColors.ActiveBorder;
            btnHuy.Location = new Point(586, 526);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 34);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmDangKy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 620);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(txtHoTen);
            Controls.Add(lblXacNhanMK);
            Controls.Add(lblMatKhau);
            Controls.Add(lblEmail);
            Controls.Add(lblSDT);
            Controls.Add(lblHoTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDangKy";
            Text = "FormDangKy";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblHoTen;
        private Label lblSDT;
        private Label lblEmail;
        private Label lblMatKhau;
        private Label lblXacNhanMK;
        private TextBox txtHoTen;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMK;
        private Button btnDangKy;
        private Button btnHuy;
        private ErrorProvider errorProvider1;
    }
}
