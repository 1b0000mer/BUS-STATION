//Sử dụng công nghệ Linq - SQL: Nguyễn Thiên Quốc - 16110191
//Thiết kế CSDL + Form

//Sử dụng công nghệ Linq - Entity: Trần Đăng Khôi Nguyên - 16119032
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHAXE_ENTITIES
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private bool checkstate()
        {
            if (frmLogin.state.login == 1)
                return true;
            else
            {
                this.customerToolStripMenuItem.Enabled = false;
                this.workerToolStripMenuItem.Enabled = false;
                return false;
            }
        }

        private void logoutStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lichkhoihanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichKH l = new frmLichKH();
            l.ShowDialog();
        }

        private void ChuyenXetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChuyenXe cx = new frmChuyenXe();
            cx.ShowDialog();
        }

        private void checktuyenxeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTuyenXe tx = new frmTuyenXe();
            tx.ShowDialog();
        }

        private void checkxekhachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXeKhach xk = new frmXeKhach();
            xk.ShowDialog();
        }

        private void listcustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.ShowDialog();
        }

        private void bookcustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatCho dc = new frmDatCho();
            dc.ShowDialog();
        }

        private void listworkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.ShowDialog();
        }

        private void bookworkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhanCong pc = new frmPhanCong();
            pc.ShowDialog();
        }

        private void aboutusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Bản quyền thuộc về: \n" +
                "Nguyễn Thiên Quốc - MSSV: 16110191 \n" +
                "Trần Đăng Khôi Nguyên - MSSV: 16119032", "Về Chúng Tôi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            checkstate();
        }
    }
}
