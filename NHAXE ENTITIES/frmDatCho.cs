using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace NHAXE_ENTITIES
{
    public partial class frmDatCho : Form
    {
        public frmDatCho()
        {
            InitializeComponent();
        }
        private bool checkstate()
        {
            if (frmLogin.state.login == 1)
            {
                return true;
            }
            else
            {
                btnDelete.Enabled = false;
                return false;
            }
        }
        private void frmDatCho_Load(object sender, EventArgs e)
        {
            checkstate();
            dgvDatCho.DataSource = DatChoBAL.getlistDATCHO();
            cbMaCXe.DataSource = ChuyenXeBAL.getlistCHUYENXE();
            cbMaKH.DataSource = KhachHangBAL.getlistKHACHHANG();
            cbNDi.DataSource = LichKHBAL.getlistLICHKH();
            cbMaCXe.DisplayMember = "MaCXe";
            cbNDi.DisplayMember = "NgayDi";
            cbMaKH.DisplayMember = "MaKH";
        }

        private void dgvDatCho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvDatCho.CurrentCell.RowIndex;
                cbMaKH.Text = dgvDatCho.Rows[r].Cells[0].Value.ToString();
                cbMaCXe.Text = dgvDatCho.Rows[r].Cells[1].Value.ToString();
                cbNDi.Text = dgvDatCho.Rows[r].Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Sorry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                frmDatCho_Load(this, new EventArgs());
            }
            catch
            {
                MessageBox.Show("Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                DatChoBAL.insertDC(Convert.ToInt32(cbMaKH.Text), Convert.ToDateTime(cbNDi.Text), cbMaCXe.Text);
                frmDatCho_Load(this, new EventArgs());
            }
            catch
            {
                MessageBox.Show("Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DatChoBAL.deleteDC(Convert.ToInt32(cbMaKH.Text), Convert.ToDateTime(cbNDi.Text), cbMaCXe.Text);
                frmDatCho_Load(this, new EventArgs());
            }
            catch
            {
                MessageBox.Show("Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXem1_Click(object sender, EventArgs e)
        {
            frmLichKH frmLKH = new frmLichKH();
            frmLKH.ShowDialog();
        }

        private void btnXem2_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.ShowDialog();
        }
    }
}
