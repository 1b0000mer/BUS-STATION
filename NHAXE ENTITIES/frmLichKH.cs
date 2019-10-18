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
    public partial class frmLichKH : Form
    {
        public frmLichKH()
        {
            InitializeComponent();
        }
        private bool checkstate()
        {
            if (frmLogin.state.login == 1)
            {
                btnKhachHang.Enabled = true;
                btnNhanVien.Enabled = true;
                return true;
            }
            else
            {
                this.btnKhachHang.Enabled = false;
                this.btnNhanVien.Enabled = false;
                this.btnDatCho.Enabled = false;
                this.btnInsert.Enabled = false;
                this.btnUpdate.Enabled = false;
                this.btnDelete.Enabled = false;
                this.cbSoHieu.Enabled = false;
                this.cbMaCXe.Enabled = false;
                this.dayNDi.Enabled = false;
                this.btnPhanCong.Enabled = false;
                return false;
            }
        }
        private void frmLichKH_Load(object sender, EventArgs e)
        {
            checkstate();
            btnChuyenXe.Enabled = true;
            dgvLichKH.DataSource = LichKHBAL.getlistLICHKH();
            cbMaCXe.DataSource = ChuyenXeBAL.getlistCHUYENXE();
            cbSoHieu.DataSource = XeKhachBAL.getlistXEKHACH();
            cbMaCXe.DisplayMember = "MaCXe";
            cbSoHieu.DisplayMember = "SoHieuXe";

        }

        private void dgvLichKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvLichKH.CurrentCell.RowIndex;
                dayNDi.Value = Convert.ToDateTime(dgvLichKH.Rows[r].Cells[0].Value.ToString());
                cbMaCXe.Text = dgvLichKH.Rows[r].Cells[1].Value.ToString();
                cbSoHieu.Text = dgvLichKH.Rows[r].Cells[2].Value.ToString();
            }
            catch { }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmLichKH_Load(this, new EventArgs());
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                LichKHBAL.insertLich(dayNDi.Value, cbMaCXe.Text, cbSoHieu.Text);
                frmLichKH_Load(this, new EventArgs());
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
                LichKHBAL.updateLich(dayNDi.Value, cbMaCXe.Text, cbSoHieu.Text);
                frmLichKH_Load(this, new EventArgs());
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
                LichKHBAL.deleteKH(dayNDi.Value, cbMaCXe.Text);
                frmLichKH_Load(this, new EventArgs());
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

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                btnNhanVien.Enabled = false;
                btnKhachHang.Enabled = false;
                btnChuyenXe.Enabled = false;
                int r = dgvLichKH.CurrentCell.RowIndex;
                dayNDi.Value = Convert.ToDateTime(dgvLichKH.Rows[r].Cells[0].Value.ToString());
                cbMaCXe.Text = dgvLichKH.Rows[r].Cells[1].Value.ToString();
                dgvLichKH.DataSource = NhanVienBAL.getlistNHANVIENCAL(dayNDi.Value, cbMaCXe.Text);
            }
            catch
            {
                MessageBox.Show("Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                btnNhanVien.Enabled = false;
                btnKhachHang.Enabled = false;
                btnChuyenXe.Enabled = false;
                int r = dgvLichKH.CurrentCell.RowIndex;
                dayNDi.Value = Convert.ToDateTime(dgvLichKH.Rows[r].Cells[0].Value.ToString());
                cbMaCXe.Text = dgvLichKH.Rows[r].Cells[1].Value.ToString();
                dgvLichKH.DataSource = KhachHangBAL.getlistKHACHHANGCAL(dayNDi.Value, cbMaCXe.Text);
            }
            catch
            {
                MessageBox.Show("Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChuyenXe_Click(object sender, EventArgs e)
        {
            try
            {
                btnNhanVien.Enabled = false;
                btnKhachHang.Enabled = false;
                btnChuyenXe.Enabled = false;
                int r = dgvLichKH.CurrentCell.RowIndex;
                cbMaCXe.Text = dgvLichKH.Rows[r].Cells[1].Value.ToString();
                dgvLichKH.DataSource = ChuyenXeBAL.getlistCHUYENXEDETAIL(cbMaCXe.Text);
            }
            catch
            {
                MessageBox.Show("Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            frmPhanCong frmPC = new frmPhanCong();
            frmPC.ShowDialog();
        }

        private void btnDatCho_Click(object sender, EventArgs e)
        {
            frmDatCho frmDC = new frmDatCho();
            frmDC.ShowDialog();
        }

        private void btnXeKhach_Click(object sender, EventArgs e)
        {
            frmXeKhach frmXK = new frmXeKhach();
            frmXK.ShowDialog();
        }
    }
}
