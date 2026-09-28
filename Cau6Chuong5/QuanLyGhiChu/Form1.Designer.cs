namespace QuanLyGhiChu
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
            menuStrip1 = new MenuStrip();
            tệpToolStripMenuItem = new ToolStripMenuItem();
            mnuMoGhiChu = new ToolStripMenuItem();
            sắpXếpCửaSổToolStripMenuItem = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            cửaSổToolStripMenuItem = new ToolStripMenuItem();
            mnuXepTang = new ToolStripMenuItem();
            mnuTileVertical = new ToolStripMenuItem();
            mnuTileHorizontal = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tệpToolStripMenuItem, cửaSổToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuMoGhiChu, sắpXếpCửaSổToolStripMenuItem, mnuThoat });
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(57, 29);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // mnuMoGhiChu
            // 
            mnuMoGhiChu.Name = "mnuMoGhiChu";
            mnuMoGhiChu.Size = new Size(270, 34);
            mnuMoGhiChu.Text = "Mở ghi chú mới";
            mnuMoGhiChu.Click += mnuMoGhiChu_Click;
            // 
            // sắpXếpCửaSổToolStripMenuItem
            // 
            sắpXếpCửaSổToolStripMenuItem.Name = "sắpXếpCửaSổToolStripMenuItem";
            sắpXếpCửaSổToolStripMenuItem.Size = new Size(270, 34);
            sắpXếpCửaSổToolStripMenuItem.Text = "Sắp xếp cửa sổ";
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(270, 34);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += menuThoat_Click;
            // 
            // cửaSổToolStripMenuItem
            // 
            cửaSổToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuXepTang, mnuTileVertical, mnuTileHorizontal });
            cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            cửaSổToolStripMenuItem.Size = new Size(83, 29);
            cửaSổToolStripMenuItem.Text = "Cửa sổ";
            // 
            // mnuXepTang
            // 
            mnuXepTang.Name = "mnuXepTang";
            mnuXepTang.Size = new Size(270, 34);
            mnuXepTang.Text = "Xếp tầng";
            mnuXepTang.Click += menuXepTang_Click;
            // 
            // mnuTileVertical
            // 
            mnuTileVertical.Name = "mnuTileVertical";
            mnuTileVertical.Size = new Size(270, 34);
            mnuTileVertical.Text = "Xếp dọc";
            mnuTileVertical.Click += menuXepDoc_Click;
            // 
            // mnuTileHorizontal
            // 
            mnuTileHorizontal.Name = "mnuTileHorizontal";
            mnuTileHorizontal.Size = new Size(270, 34);
            mnuTileHorizontal.Text = "Xếp ngang";
            mnuTileHorizontal.Click += menuXepNgang_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tệpToolStripMenuItem;
        private ToolStripMenuItem mnuMoGhiChu;
        private ToolStripMenuItem sắpXếpCửaSổToolStripMenuItem;
        private ToolStripMenuItem cửaSổToolStripMenuItem;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuXepTang;
        private ToolStripMenuItem mnuTileVertical;
        private ToolStripMenuItem mnuTileHorizontal;
        private StatusStrip statusStrip1;
    }
}
