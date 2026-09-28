namespace BanVeXemPhim
{
    partial class FormBanVe
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
            lblTenKhach = new Label();
            lblPhim = new Label();
            lblSuatChieu = new Label();
            lblGheDaChon = new Label();
            txtTenKhach = new TextBox();
            txtGheDaChon = new TextBox();
            cboPhim = new ComboBox();
            cboSuatChieu = new ComboBox();
            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblTenKhach
            // 
            lblTenKhach.AutoSize = true;
            lblTenKhach.Location = new Point(89, 24);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(93, 25);
            lblTenKhach.TabIndex = 0;
            lblTenKhach.Text = "Tên khách:";
            // 
            // lblPhim
            // 
            lblPhim.AutoSize = true;
            lblPhim.Location = new Point(89, 92);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new Size(56, 25);
            lblPhim.TabIndex = 1;
            lblPhim.Text = "Phim:";
            // 
            // lblSuatChieu
            // 
            lblSuatChieu.AutoSize = true;
            lblSuatChieu.Location = new Point(89, 170);
            lblSuatChieu.Name = "lblSuatChieu";
            lblSuatChieu.Size = new Size(97, 25);
            lblSuatChieu.TabIndex = 2;
            lblSuatChieu.Text = "Suất chiếu:";
            // 
            // lblGheDaChon
            // 
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Location = new Point(97, 258);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(116, 25);
            lblGheDaChon.TabIndex = 3;
            lblGheDaChon.Text = "Ghế đã chọn:";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(97, 57);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(415, 31);
            txtTenKhach.TabIndex = 4;
            // 
            // txtGheDaChon
            // 
            txtGheDaChon.Location = new Point(97, 286);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.ReadOnly = true;
            txtGheDaChon.Size = new Size(415, 31);
            txtGheDaChon.TabIndex = 5;
            // 
            // cboPhim
            // 
            cboPhim.FormattingEnabled = true;
            cboPhim.Items.AddRange(new object[] { "Doraemon", "Conan", "Dragon Ball", "Naruto" });
            cboPhim.Location = new Point(97, 128);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(415, 33);
            cboPhim.TabIndex = 6;
            // 
            // cboSuatChieu
            // 
            cboSuatChieu.FormattingEnabled = true;
            cboSuatChieu.Items.AddRange(new object[] { "10:00", "12:00", "14:00", "16:00", "18:00", "20:00", "22:00" });
            cboSuatChieu.Location = new Point(97, 210);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new Size(415, 33);
            cboSuatChieu.TabIndex = 7;
            // 
            // btnChonGhe
            // 
            btnChonGhe.Location = new Point(197, 374);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(112, 34);
            btnChonGhe.TabIndex = 8;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(331, 374);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(112, 34);
            btnDatVe.TabIndex = 9;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(465, 374);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 34);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormBanVe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnDatVe);
            Controls.Add(btnChonGhe);
            Controls.Add(cboSuatChieu);
            Controls.Add(cboPhim);
            Controls.Add(txtGheDaChon);
            Controls.Add(txtTenKhach);
            Controls.Add(lblGheDaChon);
            Controls.Add(lblSuatChieu);
            Controls.Add(lblPhim);
            Controls.Add(lblTenKhach);
            Name = "FormBanVe";
            Text = "FormBanVe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenKhach;
        private Label lblPhim;
        private Label lblSuatChieu;
        private Label lblGheDaChon;
        private TextBox txtTenKhach;
        private TextBox txtGheDaChon;
        private ComboBox cboPhim;
        private ComboBox cboSuatChieu;
        private Button btnChonGhe;
        private Button btnDatVe;
        private Button btnHuy;
    }
}
