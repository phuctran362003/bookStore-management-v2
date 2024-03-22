using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_PhucTG
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            UserAccountDAO userAccountDAO = new UserAccountDAO();
            UserAccount account = userAccountDAO.CheckLogin(email, password);

            if (account == null)
            {
                MessageBox.Show("Invalid email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (account != null)
            {
                MessageBox.Show("Welcome", "Welcome admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                BookManagerMainUI bookmgt = new BookManagerMainUI();
                bookmgt.Show();
                return;

            }

            //admin account:
            //   admin@bookstore.com
            //   @123Ad


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
