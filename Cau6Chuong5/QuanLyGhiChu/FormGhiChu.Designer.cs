namespace QuanLyGhiChu
{
    partial class FormGhiChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTieuDeForm = new Label();
            lblNoiDung = new Label();
            txtTieuDe = new TextBox();
            txtNoiDung = new TextBox();
            cboMucDoUuTien = new ComboBox();
            btnLuuGhiChu = new Button();
            errorProvider1 = new ErrorProvider(components);
            lblPriority = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDeForm
            // 
            lblTieuDeForm.AutoSize = true;
            lblTieuDeForm.Location = new Point(76, 25);
            lblTieuDeForm.Name = "lblTieuDeForm";
            lblTieuDeForm.Size = new Size(69, 25);
            lblTieuDeForm.TabIndex = 0;
            lblTieuDeForm.Text = "Tiêu đề";
            lblTieuDeForm.MouseDoubleClick += lblTieuDeForm_MouseDoubleClick;
            // 
            // lblNoiDung
            // 
            lblNoiDung.AutoSize = true;
            lblNoiDung.Location = new Point(76, 90);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.Size = new Size(87, 25);
            lblNoiDung.TabIndex = 1;
            lblNoiDung.Text = "Nội dung";
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(177, 25);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(551, 31);
            txtTieuDe.TabIndex = 2;
            txtTieuDe.Validating += txtTieuDe_Validating;
            txtTieuDe.Validated += txtTieuDe_Validated;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(76, 137);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(652, 209);
            txtNoiDung.TabIndex = 3;
            txtNoiDung.TextChanged += txtNoiDung_TextChanged;
            txtNoiDung.KeyPress += txtNoiDung_KeyPress;
            // 
            // cboMucDoUuTien
            // 
            cboMucDoUuTien.FormattingEnabled = true;
            cboMucDoUuTien.Items.AddRange(new object[] { "Thấp", "Trung bình", "Cao" });
            cboMucDoUuTien.Location = new Point(76, 390);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new Size(182, 33);
            cboMucDoUuTien.TabIndex = 4;
            // 
            // btnLuuGhiChu
            // 
            btnLuuGhiChu.Location = new Point(616, 390);
            btnLuuGhiChu.Name = "btnLuuGhiChu";
            btnLuuGhiChu.Size = new Size(112, 34);
            btnLuuGhiChu.TabIndex = 5;
            btnLuuGhiChu.Text = "Lưu";
            btnLuuGhiChu.UseVisualStyleBackColor = true;
            btnLuuGhiChu.Click += btnLuuGhiChu_Click;
            btnLuuGhiChu.MouseEnter += btnLuuGhiChu_MouseEnter;
            btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(77, 360);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(72, 25);
            lblPriority.TabIndex = 6;
            lblPriority.Text = "Priority:";
            // 
            // FormGhiChu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPriority);
            Controls.Add(btnLuuGhiChu);
            Controls.Add(cboMucDoUuTien);
            Controls.Add(txtNoiDung);
            Controls.Add(txtTieuDe);
            Controls.Add(lblNoiDung);
            Controls.Add(lblTieuDeForm);
            KeyPreview = true;
            Name = "FormGhiChu";
            Text = "FormGhiChu";
            KeyDown += FormGhiChu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDeForm;
        private Label lblNoiDung;
        private TextBox txtTieuDe;
        private TextBox txtNoiDung;
        private ComboBox cboMucDoUuTien;
        private Button btnLuuGhiChu;
        private ErrorProvider errorProvider1;
        private Label lblPriority;
    }
}