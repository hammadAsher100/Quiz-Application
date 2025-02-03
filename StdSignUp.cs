using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Application
{
    public partial class StdSignUp : Form
    {
        public StdSignUp()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StdLogin stdLogin = new StdLogin();
            stdLogin.Show();
            this.Hide();
        }

        private void btnStdLogin_Click(object sender, EventArgs e)
        {
            string filePath = "students.txt";

            if (txtStdUsername.Text.Trim() == "" || txtStdPassword.Text.Trim() == "")
            {
                MessageBox.Show("Username or password cannot be empty.");
                return;
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{txtStdUsername.Text.Trim()}:{txtStdPassword.Text.Trim()}");
                }
                MessageBox.Show("Sign-up successful! Now you can login");
                StdLogin form = new StdLogin();
                form.Show();
                this.Hide();
            }
        }
    }
}
