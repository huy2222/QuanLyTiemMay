using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMIS
{
    public partial class Home : Form
    {
        private Dictionary<string, UserControl> userControls = new Dictionary<string, UserControl>(); 
        public Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userControls["DatHang"] = new DatHangControl();

        }
        private void LoadUserControl(string key)
        {
            pnUC_Search.Controls.Clear();
            if (userControls.ContainsKey(key))
            {
                UserControl uc = userControls[key];
                uc.Dock = DockStyle.Fill;
                pnUC_Search.Controls.Add(uc);
            }
        }


        private void Home_Load(object sender, EventArgs e)
        {
            LoadUserControl("DatHang");
        }





 




        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {

        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
