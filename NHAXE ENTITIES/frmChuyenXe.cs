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
    public partial class frmChuyenXe : Form
    {
        public frmChuyenXe()
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
                btnInsert.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                txtMaCXe.ReadOnly = true;
                cbMaTuyen.Enabled = false;
                timeGDi.Enabled = false;
                timeGDen.Enabled = false;
                return false;
            }
        }

        private void frmChuyenXe_Load(object sender, EventArgs e)
        {
            checkstate();
            dgvChuyenXe.DataSource = ChuyenXeBAL.getlistCHUYENXE();
            cbMaTuyen.DataSource = TuyenXeBAL.getlistTUYENXE();
            cbMaTuyen.DisplayMember = "MaTuyen";
        }

        private void dgvChuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvChuyenXe.CurrentCell.RowIndex;
                txtMaCXe.Text = dgvChuyenXe.Rows[r].Cells[0].Value.ToString();
                cbMaTuyen.Text = dgvChuyenXe.Rows[r].Cells[1].Value.ToString();
                timeGDi.Value = Convert.ToDateTime(dgvChuyenXe.Rows[r].Cells[2].Value.ToString());
                timeGDen.Value = Convert.ToDateTime(dgvChuyenXe.Rows[r].Cells[3].Value.ToString());
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
                frmChuyenXe_Load(this, new EventArgs());

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
                ChuyenXeBAL.insertCX(txtMaCXe.Text, cbMaTuyen.Text, timeGDi.Value.TimeOfDay, timeGDen.Value.TimeOfDay);
                frmChuyenXe_Load(this, new EventArgs());
            }
            catch
            {
                MessageBox.Show("Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                ChuyenXeBAL.updateCX(txtMaCXe.Text, cbMaTuyen.Text, timeGDi.Value.TimeOfDay, timeGDen.Value.TimeOfDay);
                frmChuyenXe_Load(this, new EventArgs());
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
                ChuyenXeBAL.deleteCX(txtMaCXe.Text);
                frmChuyenXe_Load(this, new EventArgs());
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
    }
}
