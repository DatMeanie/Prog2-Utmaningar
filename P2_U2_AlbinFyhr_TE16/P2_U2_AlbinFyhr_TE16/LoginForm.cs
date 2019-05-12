using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_U2_AlbinFyhr_TE16
{
    public partial class LoginForm : Form
    {
        //logic class
        Logic l = new Logic();
        public LoginForm()
        {
            InitializeComponent();
        }

        //login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.UserLogin(txbUsername.Text, txbPassword.Text);
        }

        //register
        private void btnRegister_Click(object sender, EventArgs e)
        {
            l.UserRegister(txbUsername.Text, txbPassword.Text);
        }
    }
}
