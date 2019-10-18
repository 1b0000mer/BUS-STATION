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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                frmKhachHang_Load(this, new EventArgs());
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
                KhachHangBAL.insertKH(txtHoVaTen.Text, dayNSinh.Value, txtDThoai.Text, txtCMND.Text, txtDChi.Text);
                frmKhachHang_Load(this, new EventArgs());
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
                KhachHangBAL.updateKH(txtHoVaTen.Text, dayNSinh.Value, Convert.ToInt32(txtMaKH.Text), txtDThoai.Text, txtCMND.Text, txtDChi.Text);
                frmKhachHang_Load(this, new EventArgs());
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
                KhachHangBAL.deleteKH(Convert.ToInt32(txtMaKH.Text));
                frmKhachHang_Load(this, new EventArgs());
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

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvKhachHang.CurrentCell.RowIndex;
                txtHoVaTen.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
                txtMaKH.Text = dgvKhachHang.Rows[r].Cells[5].Value.ToString();
                txtDThoai.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
                txtCMND.Text = dgvKhachHang.Rows[r].Cells[3].Value.ToString();
                txtDChi.Text = dgvKhachHang.Rows[r].Cells[4].Value.ToString();
                dayNSinh.Value = Convert.ToDateTime(dgvKhachHang.Rows[r].Cells[1].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = KhachHangBAL.getlistKHACHHANG();
        }
    }
}
