using Books.Process;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Common.SendMessage(txtUserName.Handle, 0x1501, 1, "Username");
            Common.SendMessage(txtPassword.Handle, 0x1501, 1, "Password");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strUserName = txtUserName.Text.Trim();
            string strPassWord = txtPassword.Text.Trim();

            if (String.IsNullOrEmpty(strUserName) || String.IsNullOrEmpty(strPassWord))
            {
                MessageBox.Show(Constant.MSG_LOGIN_EMPTY);
                return;
            }

            if (!UserProcess.Login(strUserName, strPassWord))
            {
                MessageBox.Show(Constant.MSG_LOGIN_FAIL);
                return;
            }

            this.Hide();
            Main main = new Main();
            main.ShowDialog();

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
