namespace BanVeXemPhim
{
    partial class FormChonGhe
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
            lstGhe = new ListBox();
            lblGheDaChon = new Label();
            btnXacNhan = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lstGhe
            // 
            lstGhe.FormattingEnabled = true;
            lstGhe.Items.AddRange(new object[] { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" });
            lstGhe.Location = new Point(39, 12);
            lstGhe.Name = "lstGhe";
            lstGhe.Size = new Size(460, 254);
            lstGhe.TabIndex = 0;
            lstGhe.SelectedIndexChanged += lstGhe_SelectedIndexChanged;
            // 
            // lblGheDaChon
            // 
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Location = new Point(39, 269);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(103, 25);
            lblGheDaChon.TabIndex = 1;
            lblGheDaChon.Text = "Đang chọn:";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(264, 311);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(112, 34);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(387, 311);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 34);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "Bỏ qua";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnBoQua_Click;
            // 
            // FormChonGhe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 370);
            Controls.Add(btnHuy);
            Controls.Add(btnXacNhan);
            Controls.Add(lblGheDaChon);
            Controls.Add(lstGhe);
            Name = "FormChonGhe";
            Text = "FormChonGhe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstGhe;
        private Label lblGheDaChon;
        private Button btnXacNhan;
        private Button btnHuy;
    }
}