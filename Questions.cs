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
    public partial class Questions : Form
    {
        private string subjectName;
        private string[] questions; // Array to store questions from the file
        private int questionIndex = 0; // Tracks the current question
        private int correctAnswers = 0; //Tracks number of correct answers
        private double remainingTime; // Declare remainingTime as double
        public Questions(string subject)
        {
            InitializeComponent();
            subjectName = subject;
            // Initialize the remaining time for the countdown (5 minutes = 300 seconds)
            remainingTime = 300;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            SelectSub form = new SelectSub();
            form.Show();
            this.Hide();
        }
        private void Questions_Load(object sender, EventArgs e)
        {
            lblSubjectName.Text = "";
            lblSubjectName.Text = $"{subjectName}";
            string filePath = $"{subjectName}.txt";
            if (File.Exists(filePath))
            {
                questions = File.ReadAllLines(filePath); // Read all questions into an array
                ShuffleQuestions(); // Randomize the questions
                DisplayQuestion(); // Show the first question
                timer1.Start(); // Start Timer1
            }
            else
            {
                MessageBox.Show($"The file for {subjectName} does not exist!", "Error");
                this.Close();
            }
        }
        private void ShuffleQuestions()
        {
            // Randomize and take the 15 questions
            Random random = new Random();
            questions = questions.OrderBy(q => random.Next()).Take(15).ToArray();
        }
        private void DisplayQuestion()
        {
            if (questionIndex >= questions.Length)
            {
                double percentage = (double)correctAnswers / questions.Length * 100; // Calculate the percentage
                MessageBox.Show("Quiz completed!", "End");
                timer1.Stop();
                Result res = new Result(subjectName, questions.Length, correctAnswers, percentage);
                res.Show();
                this.Hide();
                return;
            }
            string questionLine = questions[questionIndex]; // Get the current question
            string[] parts = questionLine.Split(','); // Format: Question|OptionA|OptionB|OptionC|OptionD|Answer
            if (parts.Length >= 7)
            {
                lblsno.Text = parts[0];
                lblQuestion.Text = $"{questionIndex + 1}. {parts[1]}"; // Display the question
                btnOption01.Text = parts[2];  // Option A
                btnOption2.Text = parts[3];  // Option B
                btnOption3.Text = parts[4];  // Option C
                btnOption4.Text = parts[5];  // Option D
            }
            else
            {
                MessageBox.Show("Invalid question format in the file!", "Error");
                this.Close();
            }
            // Reset button colors and enable them for the next question
            btnOption01.BackColor = btnOption2.BackColor = btnOption3.BackColor = btnOption4.BackColor = SystemColors.Control;
            btnOption01.Enabled = btnOption2.Enabled = btnOption3.Enabled = btnOption4.Enabled = true;
            btnNextQues.Enabled = false; // Disable next button initially
        }
        private void btnNextQues_Click(object sender, EventArgs e)
        {
            questionIndex++; // Move to the next question
            DisplayQuestion(); // Show the next question
        }
        private void CheckAnswer(Button selectedButton)
        {
            string correctAnswer = "";
            int idTosearch = Convert.ToInt32(lblsno.Text);
            Button correctButton = null;
            using (StreamReader r = new StreamReader($"{subjectName}.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    int questionId = Convert.ToInt32(parts[0].Trim());
                    if (idTosearch == questionId)
                    {
                        correctAnswer = parts[6].Trim();
                        break;
                    }
                }
            }
            if (selectedButton.Text == correctAnswer)
            {
                selectedButton.BackColor = Color.LightGreen; // Correct answer selected
                correctAnswers++; // Increment correct answer count
            }
            else
            {
                selectedButton.BackColor = Color.LightCoral; // Incorrect answer
                // Find the correct button and highlight it
                if (btnOption01.Text == correctAnswer)
                    correctButton = btnOption01;

                else if (btnOption2.Text == correctAnswer)
                    correctButton = btnOption2;
                else if (btnOption3.Text == correctAnswer)
                    correctButton = btnOption3;
                else if (btnOption4.Text == correctAnswer)
                    correctButton = btnOption4;

                // Change the correct button color to LightGreen
                if (correctButton != null)
                    correctButton.BackColor = Color.LightGreen;
            }
            // Disable all options after selection
            btnOption01.Enabled = btnOption2.Enabled = btnOption3.Enabled = btnOption4.Enabled = false;
            // Enable the Next button
            btnNextQues.Enabled = true;
        }
        private void btnOption01_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnOption01);
        }
        private void btnOption2_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnOption2);
        }
        private void btnOption3_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnOption3);
        }
        private void btnOption4_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnOption4);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            // Calculate remaining minutes and seconds
            int minutes = (int)remainingTime / 60; // Minutes
            int seconds = (int)remainingTime % 60; // Seconds
            // Update the timer label in MM:SS format
            lblTimer.Text = $"Timer: {minutes:D2}:{seconds:D2}";
            if (remainingTime <= 0) // Time is up
            {
                timer1.Stop(); // Stop the timer
                EndQuiz(); // Call method to end the quiz and show results
            }
        }
        private void EndQuiz()
        {
            double percentage = (double)correctAnswers / questions.Length * 100; // Calculate the percentage
            MessageBox.Show("Your time is up!", "End");
            // Show the result form
            Result res = new Result(subjectName, questions.Length, correctAnswers, percentage);
            res.Show();
            this.Hide();
        }
    }
}