namespace DatPhongKhachSan
{
    partial class Form1
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
            lblHoTen = new Label();
            lblCCCD = new Label();
            lblNgayNhan = new Label();
            lblNgayTra = new Label();
            lblSoNguoiLon = new Label();
            lblSoTreEm = new Label();
            txtHoTen = new TextBox();
            txtCCCD = new TextBox();
            txtNgayNhan = new TextBox();
            txtNgayTra = new TextBox();
            txtSoNguoiLon = new TextBox();
            txtSoTreEm = new TextBox();
            btnDatPhong = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(154, 9);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(66, 25);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(154, 81);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(84, 25);
            lblCCCD.TabIndex = 1;
            lblCCCD.Text = "Số CCCD";
            // 
            // lblNgayNhan
            // 
            lblNgayNhan.AutoSize = true;
            lblNgayNhan.Location = new Point(154, 155);
            lblNgayNhan.Name = "lblNgayNhan";
            lblNgayNhan.Size = new Size(156, 25);
            lblNgayNhan.TabIndex = 2;
            lblNgayNhan.Text = "Ngày nhận phòng";
            // 
            // lblNgayTra
            // 
            lblNgayTra.AutoSize = true;
            lblNgayTra.Location = new Point(154, 229);
            lblNgayTra.Name = "lblNgayTra";
            lblNgayTra.Size = new Size(138, 25);
            lblNgayTra.TabIndex = 3;
            lblNgayTra.Text = "Ngày trả phòng";
            // 
            // lblSoNguoiLon
            // 
            lblSoNguoiLon.AutoSize = true;
            lblSoNguoiLon.Location = new Point(154, 301);
            lblSoNguoiLon.Name = "lblSoNguoiLon";
            lblSoNguoiLon.Size = new Size(115, 25);
            lblSoNguoiLon.TabIndex = 4;
            lblSoNguoiLon.Text = "Số người lớn";
            // 
            // lblSoTreEm
            // 
            lblSoTreEm.AutoSize = true;
            lblSoTreEm.Location = new Point(154, 375);
            lblSoTreEm.Name = "lblSoTreEm";
            lblSoTreEm.Size = new Size(89, 25);
            lblSoTreEm.TabIndex = 5;
            lblSoTreEm.Text = "Số trẻ em";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(154, 37);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(345, 31);
            txtHoTen.TabIndex = 6;
            txtHoTen.Validating += txtHoTen_Validating;
            txtHoTen.Validated += TextBox_Validated;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(154, 109);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(345, 31);
            txtCCCD.TabIndex = 7;
            txtCCCD.Validating += txtCCCD_Validating;
            txtCCCD.Validated += TextBox_Validated;
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new Point(154, 183);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new Size(345, 31);
            txtNgayNhan.TabIndex = 8;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            txtNgayNhan.Validated += TextBox_Validated;
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new Point(154, 257);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(345, 31);
            txtNgayTra.TabIndex = 9;
            txtNgayTra.Validating += txtNgayTra_Validating;
            txtNgayTra.Validated += TextBox_Validated;
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.Location = new Point(154, 329);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(345, 31);
            txtSoNguoiLon.TabIndex = 10;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            txtSoNguoiLon.Validated += TextBox_Validated;
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.Location = new Point(154, 403);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(345, 31);
            txtSoTreEm.TabIndex = 11;
            txtSoTreEm.Validating += txtSoTreEm_Validating;
            txtSoTreEm.Validated += TextBox_Validated;
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = SystemColors.HotTrack;
            btnDatPhong.ForeColor = SystemColors.ButtonFace;
            btnDatPhong.Location = new Point(156, 470);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(341, 41);
            btnDatPhong.TabIndex = 12;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(685, 618);
            Controls.Add(btnDatPhong);
            Controls.Add(txtSoTreEm);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(txtNgayTra);
            Controls.Add(txtNgayNhan);
            Controls.Add(txtCCCD);
            Controls.Add(txtHoTen);
            Controls.Add(lblSoTreEm);
            Controls.Add(lblSoNguoiLon);
            Controls.Add(lblNgayTra);
            Controls.Add(lblNgayNhan);
            Controls.Add(lblCCCD);
            Controls.Add(lblHoTen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label lblCCCD;
        private Label lblNgayNhan;
        private Label lblNgayTra;
        private Label lblSoNguoiLon;
        private Label lblSoTreEm;
        private TextBox txtHoTen;
        private TextBox txtCCCD;
        private TextBox txtNgayNhan;
        private TextBox txtNgayTra;
        private TextBox txtSoNguoiLon;
        private TextBox txtSoTreEm;
        private Button btnDatPhong;
        private ErrorProvider errorProvider1;
    }
}
