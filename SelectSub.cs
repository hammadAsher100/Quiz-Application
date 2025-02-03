using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Quiz_Application
{
    public partial class SelectSub : Form
    {
        public SelectSub()
        {
            InitializeComponent();
        }

        private void ShowQuizInstructions(string subject)
        {
            MessageBox.Show("Welcome to the quiz! You will have 5 minutes to complete it." +
            "\nEach question will have 4 options to choose from." +
            "\nClick on the correct answer and proceed to the next question." +
            "\nYou can only choose one option per question." +
            "\nYou can't skip any question." +
            "\nYour score will be shown at the end of the quiz.", "Instructions");
            Questions questionsForm = new Questions(subject);
            questionsForm.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            StdLogin stdLogin = new StdLogin();
            stdLogin.Show();
            this.Hide();
        }

        private void btnCP_Click(object sender, EventArgs e)
        {
            ShowQuizInstructions("Computer Programming");
        }

        private void btnAP_Click(object sender, EventArgs e)
        {
            ShowQuizInstructions("Applied Physics");
        }

        private void btnEng_Click(object sender, EventArgs e)
        {
            ShowQuizInstructions("Functional English");
        }

        private void btnCF_Click(object sender, EventArgs e)
        {
            ShowQuizInstructions("Computing Fundamentals");
        }

        private void btnOHS_Click(object sender, EventArgs e)
        {
            ShowQuizInstructions("Occupational Health and Safety");
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            ShowQuizInstructions("Applied Calculus and Analytical Geometry");
        }
    }
}
