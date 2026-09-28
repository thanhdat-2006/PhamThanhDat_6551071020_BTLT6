namespace QuanLyGhiChu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        public void CapNhatSoGhiChu()
        {
            statusStrip1.Text = $"Số ghi chú đang mở: {this.MdiChildren.Length}";
        }

        private void mnuMoGhiChu_Click(object sender, EventArgs e)
        {
            FormGhiChu frm = new FormGhiChu();
            frm.MdiParent = this;
            frm.Show(); //
            CapNhatSoGhiChu();

            frm.FormClosed += (s, args) => CapNhatSoGhiChu();
        }

        private void menuXepTang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void menuXepNgang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuXepDoc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
