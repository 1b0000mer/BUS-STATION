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
    public partial class frmLogin : Form
    {
        public class state
        {
            public static int login;
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if ((this.txtUser.Text == "admin") && (this.txtPass.Text == "admin"))
            {
                state.login = 1;
                this.Close();
            }
            else
             if ((this.txtUser.Text == "guest") && (this.txtPass.Text == ""))
            {
                state.login = 2;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sorry Wrong Name or Password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUser.Clear();
                this.txtPass.Clear();
                this.txtUser.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.txtUser.Focus();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(this, new EventArgs());
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(this, new EventArgs());
            }
        }
    }
}
