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
    public partial class frmTuyenXe : Form
    {
        public frmTuyenXe()
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
                txtMaTuyen.ReadOnly = true;
                txtDDi.ReadOnly = true;
                txtDDen.ReadOnly = true;
                return false;
            }
        }
        private void frmTuyenXe_Load(object sender, EventArgs e)
        {
            checkstate();
            dgvTuyenXe.DataSource = TuyenXeBAL.getlistTUYENXE();
        }
        private void dgvTuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTuyenXe.CurrentCell.RowIndex;
            txtMaTuyen.Text = dgvTuyenXe.Rows[r].Cells[0].Value.ToString();
            txtDDi.Text = dgvTuyenXe.Rows[r].Cells[1].Value.ToString();
            txtDDen.Text = dgvTuyenXe.Rows[r].Cells[2].Value.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                frmTuyenXe_Load(this, new EventArgs());
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
                TuyenXeBAL.insertTX(txtMaTuyen.Text, txtDDi.Text, txtDDen.Text);
                frmTuyenXe_Load(this, new EventArgs());
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
                TuyenXeBAL.updateTX(txtMaTuyen.Text, txtDDi.Text, txtDDen.Text);
                frmTuyenXe_Load(this, new EventArgs());
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
                TuyenXeBAL.deleteTX(txtMaTuyen.Text);
                frmTuyenXe_Load(this, new EventArgs());
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
