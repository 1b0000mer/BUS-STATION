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
    public partial class frmPhanCong : Form
    {
        public frmPhanCong()
        {
            InitializeComponent();
        }

        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            dgvPhanCong.DataSource = PhanCongBAL.getlistPHANCONG();
            cbMaCXe.DataSource = ChuyenXeBAL.getlistCHUYENXE();
            cbMaNV.DataSource = NhanVienBAL.getlistNHANVIEN();
            cbNDi.DataSource = LichKHBAL.getlistLICHKH();
            cbMaNV.DisplayMember = "MaNV";
            cbMaCXe.DisplayMember = "MaCXe";
            cbNDi.DisplayMember = "NgayDi";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            frmLichKH frm = new frmLichKH();
            frm.ShowDialog();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                PhanCongBAL.insertPC(cbMaNV.Text, Convert.ToDateTime(cbNDi.Text), cbMaCXe.Text);
                frmPhanCong_Load(this, new EventArgs());
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
                PhanCongBAL.deletePC(cbMaNV.Text, Convert.ToDateTime(cbNDi.Text), cbMaCXe.Text);
                frmPhanCong_Load(this, new EventArgs());
            }
            catch
            {
                MessageBox.Show("Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                frmPhanCong_Load(this, new EventArgs());
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

        private void dgvPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvPhanCong.CurrentCell.RowIndex;
                cbMaNV.Text = dgvPhanCong.Rows[r].Cells[0].Value.ToString();
                cbMaCXe.Text = dgvPhanCong.Rows[r].Cells[1].Value.ToString();
                cbNDi.Text = dgvPhanCong.Rows[r].Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
