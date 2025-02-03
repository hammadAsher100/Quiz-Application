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
    public partial class Adminn : Form
    {
        public Adminn()
        {
            InitializeComponent();
        }
        private void btnAddQues_Click(object sender, EventArgs e)
        {
            PanelAddQues.Visible = true;
        }
        private void Adminn_Load(object sender, EventArgs e)
        {
            PanelAddQues.Visible = false;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string filePath = $"{cbSelectSubject.Text}.txt";
            if (File.Exists(filePath))
            {
                try
                {
                    int sno = 1; // Default serial number
                    if (File.Exists(filePath))
                    {
                        // Read all lines from the file
                        string[] lines = File.ReadAllLines(filePath);
                        if (lines.Length > 0)
                        {
                            // Get the last line
                            string lastLine = lines[lines.Length - 1];
                            string[] parts = lastLine.Split(',');
                            // Extract and increment the serial number
                            sno = int.Parse(parts[0]) + 1;
                        }
                    }
                    // Write the new question to the file
                    using (StreamWriter sw = new StreamWriter(filePath, true))
                    {
                        sw.WriteLine($"{sno},{txtAddQues.Text.Trim()},{txtAddOpt01.Text.Trim()},{txtAddOpt02.Text.Trim()},{txtAddOpt03.Text.Trim()},{txtAddOpt04.Text.Trim()},{txtAddCorrectOpt.Text.Trim()}");
                    }
                    MessageBox.Show("Question added successfully!", "Success");
                    // Clear the textboxes for the next entry
                    txtAddQues.Clear();
                    txtAddOpt01.Clear();
                    txtAddOpt02.Clear();
                    txtAddOpt03.Clear();
                    txtAddOpt04.Clear();
                    txtAddCorrectOpt.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}\n{ex.Message}", "Error");
                }
            }
            else
            {
                txtAddQues.Clear();
                txtAddOpt01.Clear();
                txtAddOpt02.Clear();
                txtAddOpt03.Clear();
                txtAddOpt04.Clear();
                txtAddCorrectOpt.Clear();
                MessageBox.Show("The file doesn't exist..","Error");
            }
        }
        private void btnViewQues_Click(object sender, EventArgs e)
        {
            ViewQues form = new ViewQues();
            form.Show();
            this.Hide();
        }
    }
}