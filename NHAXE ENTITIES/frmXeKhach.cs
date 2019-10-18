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
    public partial class frmXeKhach : Form
    {
        public frmXeKhach()
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
                txtSoHieu.ReadOnly = true;
                txtSoGhe.ReadOnly = true;
                return false;
            }
        }
        private void frmXeKhach_Load(object sender, EventArgs e)
        {
            checkstate();
            dgvXeKhach.DataSource = XeKhachBAL.getlistXEKHACH();
        }

        private void dgvXeKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvXeKhach.CurrentCell.RowIndex;
                txtSoHieu.Text = dgvXeKhach.Rows[r].Cells[0].Value.ToString();
                txtSoGhe.Text = dgvXeKhach.Rows[r].Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            frmXeKhach_Load(this, new EventArgs());
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                XeKhachBAL.insertXK(txtSoHieu.Text, Convert.ToInt32(txtSoGhe.Text));
                frmXeKhach_Load(this, new EventArgs());
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
                XeKhachBAL.updateXK(txtSoHieu.Text, Convert.ToInt32(txtSoGhe.Text));
                frmXeKhach_Load(this, new EventArgs());
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
                XeKhachBAL.deleteXK(txtSoHieu.Text);
                frmXeKhach_Load(this, new EventArgs());
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
