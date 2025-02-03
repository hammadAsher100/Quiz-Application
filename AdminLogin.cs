using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Application
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            QuizApp quizapp = new QuizApp();
            quizapp.Show();
            this.Hide();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string adminUN = "admin";
            string adminPASS = "admin021";
            if (txtAdminUsername.Text.Trim() == "" || txtAdminPassword.Text.Trim() == "")
            {
                MessageBox.Show("Username or Password is missing.");
            }
            else if (txtAdminUsername.Text.Trim() == adminUN && txtAdminPassword.Text.Trim() == adminPASS)
            {
                MessageBox.Show("Login Successfull!");
                Adminn adminForm = new Adminn();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password.");
                txtAdminUsername.Text = "";
                txtAdminPassword.Text = "";
            }
        }
    }
}
