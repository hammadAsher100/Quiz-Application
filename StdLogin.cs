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
    public partial class StdLogin : Form
    {
        public StdLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            QuizApp quizApp = new QuizApp();
            quizApp.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            StdSignUp quizSignUp = new StdSignUp();
            quizSignUp.Show();
            this.Hide();
        }

        private void btnStdLogin_Click(object sender, EventArgs e)
        {
            if (txtStdUsername.Text.Trim() == "" || txtStdPassword.Text.Trim() == "")
            {
                MessageBox.Show("Username or Password is missing.");
            }
            else
            {
            string filePath = "students.txt";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    bool isValid = false;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(':');

                        if (parts.Length == 2 && parts[0] == txtStdUsername.Text.Trim() && parts[1] == txtStdPassword.Text.Trim())
                        {
                            isValid = true;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        MessageBox.Show("Login successfull!");
                        this.Hide();
                        SelectSub select = new SelectSub();
                        select.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password.");
                        txtStdUsername.Text = "";
                        txtStdPassword.Text = "";
                    }
                }
            }
        }
    }
}
