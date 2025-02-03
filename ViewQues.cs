using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quiz_Application
{
    public partial class ViewQues : Form
    {
        public ViewQues()
        {
            InitializeComponent();
        }

        private void cbViewQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = $"{cbViewQuestions.Text}.txt";
            if (File.Exists(fileName))
            {
                lstViewQues.Items.Clear(); // Clear previous items
                try
                {
                    string[] lines = File.ReadAllLines(fileName);
                    if (lines.Length == 0)
                    {
                        MessageBox.Show("No questions found in the file.", "Info");
                        return;
                    }
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length >= 7)
                        {
                            // Format the question for display
                            string Ques = $"Q{parts[0]}: {parts[1]}";  // Question
                            string opt1n2 = $"   A) {parts[2]}          B) {parts[3]}";      // Option A,B
                            string opt3n4 = $"   C) {parts[4]}          D) {parts[5]}";      // Option C,D
                            string correctOpt = $"   Correct Answer: {parts[6]}";  // Correct Answer
                            lstViewQues.Items.Add($"{Ques}");
                            lstViewQues.Items.Add($"{opt1n2}");
                            lstViewQues.Items.Add($"{opt3n4}");
                            lstViewQues.Items.Add($"{correctOpt}");
                            lstViewQues.Items.Add(""); // Add a blank line for spacing
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading questions: {ex.Message}", "Error");
                }
            }
            else
            {
                MessageBox.Show("File does not exist or no questions available.", "Error");
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Adminn adminn = new Adminn();
            adminn.Show();
            this.Hide();
        }
    }
}
