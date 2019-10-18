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
    public partial class frmViTri : Form
    {
        public frmViTri()
        {
            InitializeComponent();
        }

        private void frmViTri_Load(object sender, EventArgs e)
        {
            dgvViTri.DataSource = ViTriBAL.getlistVITRI();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                dgvViTri.DataSource = ViTriBAL.getlistVITRI();
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
                ViTriBAL.insertVT(Convert.ToInt32(txtMaViTri.Text), txtTenViTri.Text);
                frmViTri_Load(this, new EventArgs());
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
                ViTriBAL.updateVT(Convert.ToInt32(txtMaViTri.Text), txtTenViTri.Text);
                frmViTri_Load(this, new EventArgs());
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
                ViTriBAL.deleteVT(Convert.ToInt32(txtMaViTri.Text));
                frmViTri_Load(this, new EventArgs());
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

        private void dgvViTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvViTri.CurrentCell.RowIndex;
                txtMaViTri.Text = dgvViTri.Rows[r].Cells[0].Value.ToString();
                txtTenViTri.Text = dgvViTri.Rows[r].Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
