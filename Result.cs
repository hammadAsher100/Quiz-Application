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
    public partial class Result : Form
    {
        public Result(string subject, int totalMarks, int obtainedMarks, double percentage)
        {
            InitializeComponent();
            txtResSubject.Text = subject;
            txtTotalMarks.Text = totalMarks.ToString();
            txtObtainedMarls.Text = obtainedMarks.ToString();
            txtPercentage.Text = $"{percentage:F2}%"; // Display the percentage formatted to 2 decimal places
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            StdLogin form = new StdLogin();
            form.Show();
            this.Hide();
        }
        private void btnAnother_Click(object sender, EventArgs e)
        {
            SelectSub form = new SelectSub();
            form.Show();
            this.Hide();
        }
    }
}
