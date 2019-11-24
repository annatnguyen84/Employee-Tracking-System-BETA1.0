namespace ETS.View
{
    partial class Form1
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
            this.btnManageDetails = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmpDetails = new System.Windows.Forms.Button();
            this.btnLogHours = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageDetails
            // 
            this.btnManageDetails.Location = new System.Drawing.Point(91, 122);
            this.btnManageDetails.Name = "btnManageDetails";
            this.btnManageDetails.Size = new System.Drawing.Size(265, 45);
            this.btnManageDetails.TabIndex = 8;
            this.btnManageDetails.Text = "Manage Employee Details";
            this.btnManageDetails.UseVisualStyleBackColor = true;
            this.btnManageDetails.Click += new System.EventHandler(this.btnManageDetails_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(91, 284);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(265, 45);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employees Tracking System";
            // 
            // btnEmpDetails
            // 
            this.btnEmpDetails.Location = new System.Drawing.Point(91, 68);
            this.btnEmpDetails.Name = "btnEmpDetails";
            this.btnEmpDetails.Size = new System.Drawing.Size(265, 45);
            this.btnEmpDetails.TabIndex = 5;
            this.btnEmpDetails.Text = "Employee Details";
            this.btnEmpDetails.UseVisualStyleBackColor = true;
            this.btnEmpDetails.Click += new System.EventHandler(this.btnEmpDetails_Click);
            // 
            // btnLogHours
            // 
            this.btnLogHours.Location = new System.Drawing.Point(91, 176);
            this.btnLogHours.Name = "btnLogHours";
            this.btnLogHours.Size = new System.Drawing.Size(265, 45);
            this.btnLogHours.TabIndex = 10;
            this.btnLogHours.Text = "Log Employee Hours";
            this.btnLogHours.UseVisualStyleBackColor = true;
            this.btnLogHours.Click += new System.EventHandler(this.btnLogHours_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 362);
            this.Controls.Add(this.btnLogHours);
            this.Controls.Add(this.btnManageDetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmpDetails);
            this.Name = "Form1";
            this.Text = "Selection Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpDetails;
        private System.Windows.Forms.Button btnLogHours;
    }
}

