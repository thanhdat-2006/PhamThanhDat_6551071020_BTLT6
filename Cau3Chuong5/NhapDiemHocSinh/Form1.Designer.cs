namespace NhapDiemHocSinh
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
            lblMaHS = new Label();
            lblHoTen = new Label();
            lblToan = new Label();
            lblVan = new Label();
            lblAnh = new Label();
            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtToan = new TextBox();
            txtVan = new TextBox();
            txtAnh = new TextBox();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            errorProvider1 = new ErrorProvider(components);
            lstDanhSach = new ListBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblMaHS
            // 
            lblMaHS.AutoSize = true;
            lblMaHS.Location = new Point(50, 21);
            lblMaHS.Name = "lblMaHS";
            lblMaHS.Size = new Size(65, 25);
            lblMaHS.TabIndex = 0;
            lblMaHS.Text = "Mã HS";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(181, 21);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(66, 25);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ tên";
            // 
            // lblToan
            // 
            lblToan.AutoSize = true;
            lblToan.Location = new Point(323, 21);
            lblToan.Name = "lblToan";
            lblToan.Size = new Size(96, 25);
            lblToan.TabIndex = 2;
            lblToan.Text = "Điểm Toán";
            // 
            // lblVan
            // 
            lblVan.AutoSize = true;
            lblVan.Location = new Point(464, 21);
            lblVan.Name = "lblVan";
            lblVan.Size = new Size(88, 25);
            lblVan.TabIndex = 3;
            lblVan.Text = "Điểm Văn";
            // 
            // lblAnh
            // 
            lblAnh.AutoSize = true;
            lblAnh.Location = new Point(604, 21);
            lblAnh.Name = "lblAnh";
            lblAnh.Size = new Size(91, 25);
            lblAnh.TabIndex = 4;
            lblAnh.Text = "Điểm Anh";
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(50, 49);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(95, 31);
            txtMaHS.TabIndex = 0;
            txtMaHS.TabStop = false;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(181, 49);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(95, 31);
            txtHoTen.TabIndex = 1;
            txtHoTen.TabStop = false;
            // 
            // txtToan
            // 
            txtToan.Location = new Point(324, 49);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(95, 31);
            txtToan.TabIndex = 2;
            txtToan.TabStop = false;
            // 
            // txtVan
            // 
            txtVan.Location = new Point(464, 49);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(95, 31);
            txtVan.TabIndex = 3;
            txtVan.TabStop = false;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(604, 49);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(95, 31);
            txtAnh.TabIndex = 4;
            txtAnh.TabStop = false;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.LimeGreen;
            btnLuu.Location = new Point(49, 110);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 5;
            btnLuu.TabStop = false;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(194, 110);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(112, 34);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.TabStop = false;
            btnXoaTrang.Text = "Xóa trắng";
            btnXoaTrang.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lstDanhSach
            // 
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.Location = new Point(49, 166);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.Size = new Size(646, 279);
            lstDanhSach.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 481);
            Controls.Add(lstDanhSach);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(txtAnh);
            Controls.Add(txtVan);
            Controls.Add(txtToan);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaHS);
            Controls.Add(lblAnh);
            Controls.Add(lblVan);
            Controls.Add(lblToan);
            Controls.Add(lblHoTen);
            Controls.Add(lblMaHS);
            Name = "Form1";
            Text = "FormNhapDiem";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaHS;
        private Label lblHoTen;
        private Label lblToan;
        private Label lblVan;
        private Label lblAnh;
        private TextBox txtMaHS;
        private TextBox txtHoTen;
        private TextBox txtToan;
        private TextBox txtVan;
        private TextBox txtAnh;
        private Button btnLuu;
        private Button btnXoaTrang;
        private ErrorProvider errorProvider1;
        private ListBox lstDanhSach;
    }
}
