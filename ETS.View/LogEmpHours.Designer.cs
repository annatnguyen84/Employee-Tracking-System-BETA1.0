namespace ETS.View
{
    partial class LogEmpHours
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
            this.dtpWorkDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLogHrs = new System.Windows.Forms.Button();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvEmpHours = new System.Windows.Forms.ListView();
            this.EmpID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateWorked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // dtpWorkDate
            // 
            this.dtpWorkDate.Location = new System.Drawing.Point(13, 147);
            this.dtpWorkDate.Name = "dtpWorkDate";
            this.dtpWorkDate.Size = new System.Drawing.Size(325, 26);
            this.dtpWorkDate.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(329, 44);
            this.label8.TabIndex = 65;
            this.label8.Text = "Working Hours";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(13, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 23);
            this.label9.TabIndex = 63;
            this.label9.Text = "Total Hours Worked:";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(13, 210);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(325, 26);
            this.txtHours.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(13, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 23);
            this.label10.TabIndex = 62;
            this.label10.Text = "Date: ";
            // 
            // btnLogHrs
            // 
            this.btnLogHrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogHrs.Location = new System.Drawing.Point(12, 257);
            this.btnLogHrs.Name = "btnLogHrs";
            this.btnLogHrs.Size = new System.Drawing.Size(285, 41);
            this.btnLogHrs.TabIndex = 61;
            this.btnLogHrs.Text = "Log Hours";
            this.btnLogHrs.UseVisualStyleBackColor = true;
            this.btnLogHrs.Click += new System.EventHandler(this.btnLogHrs_Click);
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(13, 83);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(325, 26);
            this.txtEmpID.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 59;
            this.label1.Text = "Employee ID: ";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 439);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(285, 41);
            this.btnBack.TabIndex = 67;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(12, 317);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(285, 41);
            this.btnSearch.TabIndex = 68;
            this.btnSearch.Text = "Search by ID";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lvEmpHours
            // 
            this.lvEmpHours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmpID,
            this.FullName,
            this.DateWorked,
            this.Hours});
            this.lvEmpHours.HideSelection = false;
            this.lvEmpHours.Location = new System.Drawing.Point(366, 12);
            this.lvEmpHours.Name = "lvEmpHours";
            this.lvEmpHours.Size = new System.Drawing.Size(730, 468);
            this.lvEmpHours.TabIndex = 69;
            this.lvEmpHours.UseCompatibleStateImageBehavior = false;
            this.lvEmpHours.View = System.Windows.Forms.View.Details;
            // 
            // EmpID
            // 
            this.EmpID.Text = "Employee ID";
            this.EmpID.Width = 119;
            // 
            // FullName
            // 
            this.FullName.Text = "Full Name";
            this.FullName.Width = 143;
            // 
            // DateWorked
            // 
            this.DateWorked.Text = "Date Worked";
            this.DateWorked.Width = 152;
            // 
            // Hours
            // 
            this.Hours.Text = "Hours";
            this.Hours.Width = 109;
            // 
            // LogEmpHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 492);
            this.Controls.Add(this.lvEmpHours);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtpWorkDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnLogHrs);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label1);
            this.Name = "LogEmpHours";
            this.Text = "LogEmpHours";
            this.Load += new System.EventHandler(this.LogEmpHours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpWorkDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLogHrs;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvEmpHours;
        private System.Windows.Forms.ColumnHeader EmpID;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader DateWorked;
        private System.Windows.Forms.ColumnHeader Hours;
    }
}