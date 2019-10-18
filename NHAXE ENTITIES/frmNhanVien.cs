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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = NhanVienBAL.getlistNHANVIEN();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                frmNhanVien_Load(this, new EventArgs());
            }
            catch
            {
                MessageBox.Show("Không thực hiện được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVienBAL.insertNV(txtHoVaTen.Text, dayNSinh.Value, txtMaNV.Text, txtDThoai.Text, txtCMND.Text, txtDChi.Text, Convert.ToInt32(txtMaViTri.Text));
                frmNhanVien_Load(this, new EventArgs());
            }
            catch
            {
                MessageBox.Show("Không thực hiện được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVienBAL.updateNV(txtHoVaTen.Text, dayNSinh.Value, txtMaNV.Text, txtDThoai.Text, txtCMND.Text, txtDChi.Text, Convert.ToInt32(txtMaViTri.Text));
                frmNhanVien_Load(this, new EventArgs());
            }
            catch
            {
                MessageBox.Show("Không thực hiện được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVienBAL.deleteNV(txtMaNV.Text);
                frmNhanVien_Load(this, new EventArgs());
            }
            catch
            {
                MessageBox.Show("Không thực hiện được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvNhanVien.CurrentCell.RowIndex;
                txtHoVaTen.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
                dayNSinh.Value = Convert.ToDateTime(dgvNhanVien.Rows[r].Cells[1].Value.ToString());
                txtMaNV.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
                txtDThoai.Text = dgvNhanVien.Rows[r].Cells[3].Value.ToString();
                txtCMND.Text = dgvNhanVien.Rows[r].Cells[4].Value.ToString();
                txtDChi.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
                txtMaViTri.Text = dgvNhanVien.Rows[r].Cells[6].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
