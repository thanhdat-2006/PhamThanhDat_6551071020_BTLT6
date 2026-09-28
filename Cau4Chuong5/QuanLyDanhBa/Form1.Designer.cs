namespace QuanLyDanhBa
{
    partial class frmDanhBa
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
            lstLienHe = new ListBox();
            lblTen = new Label();
            lblSDT = new Label();
            txtTen = new TextBox();
            txtSDT = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lstLienHe
            // 
            lstLienHe.FormattingEnabled = true;
            lstLienHe.Location = new Point(12, 12);
            lstLienHe.Name = "lstLienHe";
            lstLienHe.Size = new Size(373, 404);
            lstLienHe.TabIndex = 0;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(442, 18);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(38, 25);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(442, 101);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(117, 25);
            lblSDT.TabIndex = 2;
            lblSDT.Text = "Số điện thoại";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(442, 56);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(320, 31);
            txtTen.TabIndex = 3;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(442, 139);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(320, 31);
            txtSDT.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(650, 200);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(650, 240);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(650, 280);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(650, 382);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmDanhBa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSDT);
            Controls.Add(txtTen);
            Controls.Add(lblSDT);
            Controls.Add(lblTen);
            Controls.Add(lstLienHe);
            Name = "frmDanhBa";
            Text = "FormDanhBa";
            FormClosing += FormDanhBa_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLienHe;
        private Label lblTen;
        private Label lblSDT;
        private TextBox txtTen;
        private TextBox txtSDT;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
    }
}
