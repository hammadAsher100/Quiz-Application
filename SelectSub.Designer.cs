namespace Quiz_Application
{
    partial class SelectSub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectSub));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnEng = new System.Windows.Forms.Button();
            this.btnOHS = new System.Windows.Forms.Button();
            this.btnAP = new System.Windows.Forms.Button();
            this.btnCF = new System.Windows.Forms.Button();
            this.btnCP = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a subject and test your knowledge!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnCal);
            this.panel1.Controls.Add(this.btnEng);
            this.panel1.Controls.Add(this.btnOHS);
            this.panel1.Controls.Add(this.btnAP);
            this.panel1.Controls.Add(this.btnCF);
            this.panel1.Controls.Add(this.btnCP);
            this.panel1.Location = new System.Drawing.Point(80, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 255);
            this.panel1.TabIndex = 2;
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.ForeColor = System.Drawing.Color.Black;
            this.btnCal.Location = new System.Drawing.Point(415, 130);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(168, 78);
            this.btnCal.TabIndex = 5;
            this.btnCal.Text = "Applied Calculus and Analytical Geometry";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnEng
            // 
            this.btnEng.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEng.ForeColor = System.Drawing.Color.Black;
            this.btnEng.Location = new System.Drawing.Point(415, 43);
            this.btnEng.Name = "btnEng";
            this.btnEng.Size = new System.Drawing.Size(168, 78);
            this.btnEng.TabIndex = 4;
            this.btnEng.Text = "Functional English";
            this.btnEng.UseVisualStyleBackColor = true;
            this.btnEng.Click += new System.EventHandler(this.btnEng_Click);
            // 
            // btnOHS
            // 
            this.btnOHS.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOHS.ForeColor = System.Drawing.Color.Black;
            this.btnOHS.Location = new System.Drawing.Point(234, 130);
            this.btnOHS.Name = "btnOHS";
            this.btnOHS.Size = new System.Drawing.Size(168, 78);
            this.btnOHS.TabIndex = 3;
            this.btnOHS.Text = "Occupational Health and Safety";
            this.btnOHS.UseVisualStyleBackColor = true;
            this.btnOHS.Click += new System.EventHandler(this.btnOHS_Click);
            // 
            // btnAP
            // 
            this.btnAP.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAP.ForeColor = System.Drawing.Color.Black;
            this.btnAP.Location = new System.Drawing.Point(234, 43);
            this.btnAP.Name = "btnAP";
            this.btnAP.Size = new System.Drawing.Size(168, 78);
            this.btnAP.TabIndex = 2;
            this.btnAP.Text = "Applied Physics";
            this.btnAP.UseVisualStyleBackColor = true;
            this.btnAP.Click += new System.EventHandler(this.btnAP_Click);
            // 
            // btnCF
            // 
            this.btnCF.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCF.ForeColor = System.Drawing.Color.Black;
            this.btnCF.Location = new System.Drawing.Point(51, 130);
            this.btnCF.Name = "btnCF";
            this.btnCF.Size = new System.Drawing.Size(168, 78);
            this.btnCF.TabIndex = 1;
            this.btnCF.Text = "Computing Fundamentals";
            this.btnCF.UseVisualStyleBackColor = true;
            this.btnCF.Click += new System.EventHandler(this.btnCF_Click);
            // 
            // btnCP
            // 
            this.btnCP.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCP.ForeColor = System.Drawing.Color.Black;
            this.btnCP.Location = new System.Drawing.Point(51, 43);
            this.btnCP.Name = "btnCP";
            this.btnCP.Size = new System.Drawing.Size(168, 78);
            this.btnCP.TabIndex = 0;
            this.btnCP.Text = "Computer Programming";
            this.btnCP.UseVisualStyleBackColor = true;
            this.btnCP.Click += new System.EventHandler(this.btnCP_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold);
            this.btnlogout.Location = new System.Drawing.Point(676, 410);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(112, 28);
            this.btnlogout.TabIndex = 7;
            this.btnlogout.Text = "LOG OUT";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // SelectSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectSub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Application";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnEng;
        private System.Windows.Forms.Button btnOHS;
        private System.Windows.Forms.Button btnAP;
        private System.Windows.Forms.Button btnCF;
        private System.Windows.Forms.Button btnCP;
        private System.Windows.Forms.Button btnlogout;
    }
}