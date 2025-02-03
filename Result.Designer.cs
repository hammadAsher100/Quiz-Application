namespace Quiz_Application
{
    partial class Result
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAnother = new System.Windows.Forms.Button();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.txtObtainedMarls = new System.Windows.Forms.TextBox();
            this.txtResSubject = new System.Windows.Forms.TextBox();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.lblObtainedMarks = new System.Windows.Forms.Label();
            this.lblResSubject = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUIZ RESULTS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.txtPercentage);
            this.panel1.Controls.Add(this.txtObtainedMarls);
            this.panel1.Controls.Add(this.txtResSubject);
            this.panel1.Controls.Add(this.txtTotalMarks);
            this.panel1.Controls.Add(this.lblObtainedMarks);
            this.panel1.Controls.Add(this.lblResSubject);
            this.panel1.Controls.Add(this.lblPercentage);
            this.panel1.Controls.Add(this.lblTotalMarks);
            this.panel1.Location = new System.Drawing.Point(79, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 252);
            this.panel1.TabIndex = 5;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.Location = new System.Drawing.Point(511, 365);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(213, 48);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAnother
            // 
            this.btnAnother.BackColor = System.Drawing.Color.White;
            this.btnAnother.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAnother.Location = new System.Drawing.Point(79, 365);
            this.btnAnother.Name = "btnAnother";
            this.btnAnother.Size = new System.Drawing.Size(213, 48);
            this.btnAnother.TabIndex = 10;
            this.btnAnother.Text = "ANOTHER QUIZ?";
            this.btnAnother.UseVisualStyleBackColor = false;
            this.btnAnother.Click += new System.EventHandler(this.btnAnother_Click);
            // 
            // txtPercentage
            // 
            this.txtPercentage.Enabled = false;
            this.txtPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentage.Location = new System.Drawing.Point(235, 176);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(309, 22);
            this.txtPercentage.TabIndex = 32;
            this.txtPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtObtainedMarls
            // 
            this.txtObtainedMarls.Enabled = false;
            this.txtObtainedMarls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObtainedMarls.Location = new System.Drawing.Point(235, 138);
            this.txtObtainedMarls.Name = "txtObtainedMarls";
            this.txtObtainedMarls.Size = new System.Drawing.Size(309, 22);
            this.txtObtainedMarls.TabIndex = 33;
            this.txtObtainedMarls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResSubject
            // 
            this.txtResSubject.Enabled = false;
            this.txtResSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResSubject.Location = new System.Drawing.Point(235, 61);
            this.txtResSubject.Name = "txtResSubject";
            this.txtResSubject.Size = new System.Drawing.Size(309, 22);
            this.txtResSubject.TabIndex = 34;
            this.txtResSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Enabled = false;
            this.txtTotalMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMarks.Location = new System.Drawing.Point(235, 98);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(309, 22);
            this.txtTotalMarks.TabIndex = 35;
            this.txtTotalMarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblObtainedMarks
            // 
            this.lblObtainedMarks.AutoSize = true;
            this.lblObtainedMarks.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObtainedMarks.ForeColor = System.Drawing.Color.Black;
            this.lblObtainedMarks.Location = new System.Drawing.Point(75, 133);
            this.lblObtainedMarks.Name = "lblObtainedMarks";
            this.lblObtainedMarks.Size = new System.Drawing.Size(154, 25);
            this.lblObtainedMarks.TabIndex = 31;
            this.lblObtainedMarks.Text = "Obtained Marks:";
            this.lblObtainedMarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResSubject
            // 
            this.lblResSubject.AutoSize = true;
            this.lblResSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResSubject.ForeColor = System.Drawing.Color.Black;
            this.lblResSubject.Location = new System.Drawing.Point(75, 57);
            this.lblResSubject.Name = "lblResSubject";
            this.lblResSubject.Size = new System.Drawing.Size(80, 25);
            this.lblResSubject.TabIndex = 28;
            this.lblResSubject.Text = "Subject:";
            this.lblResSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.ForeColor = System.Drawing.Color.Black;
            this.lblPercentage.Location = new System.Drawing.Point(75, 171);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(112, 25);
            this.lblPercentage.TabIndex = 30;
            this.lblPercentage.Text = "Percentage:";
            this.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMarks.ForeColor = System.Drawing.Color.Black;
            this.lblTotalMarks.Location = new System.Drawing.Point(75, 94);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(116, 25);
            this.lblTotalMarks.TabIndex = 29;
            this.lblTotalMarks.Text = "Total Marks:";
            this.lblTotalMarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnother);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Application";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAnother;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.TextBox txtObtainedMarls;
        private System.Windows.Forms.TextBox txtResSubject;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.Label lblObtainedMarks;
        private System.Windows.Forms.Label lblResSubject;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblTotalMarks;
    }
}