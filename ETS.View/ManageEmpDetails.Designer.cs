namespace ETS.View
{
    partial class ManageEmpDetails
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
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.MtxtEmpID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MtxtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MtxtFName = new System.Windows.Forms.TextBox();
            this.MtxtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MtxtLName = new System.Windows.Forms.TextBox();
            this.MdtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnSearchByID = new System.Windows.Forms.Button();
            this.lvEmpList = new System.Windows.Forms.ListView();
            this.vlEmpID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vlFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vlEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearchEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(329, 44);
            this.label11.TabIndex = 59;
            this.label11.Text = "Employee List";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(695, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 44);
            this.label7.TabIndex = 53;
            this.label7.Text = "Update Details";
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(1057, 185);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(284, 41);
            this.BtnSave.TabIndex = 51;
            this.BtnSave.Text = "Save Changes";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1057, 389);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(284, 41);
            this.btnBack.TabIndex = 50;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MtxtEmpID
            // 
            this.MtxtEmpID.Location = new System.Drawing.Point(698, 89);
            this.MtxtEmpID.Name = "MtxtEmpID";
            this.MtxtEmpID.Size = new System.Drawing.Size(325, 26);
            this.MtxtEmpID.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(697, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "Phone: ";
            // 
            // MtxtPhone
            // 
            this.MtxtPhone.Location = new System.Drawing.Point(698, 404);
            this.MtxtPhone.Name = "MtxtPhone";
            this.MtxtPhone.Size = new System.Drawing.Size(325, 26);
            this.MtxtPhone.TabIndex = 48;
            this.MtxtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.MtxtPhone_Validating);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(697, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "DOB: ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(697, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "Email: ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(697, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "First Name: ";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(697, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Last Name:";
            // 
            // MtxtFName
            // 
            this.MtxtFName.Location = new System.Drawing.Point(698, 152);
            this.MtxtFName.Name = "MtxtFName";
            this.MtxtFName.Size = new System.Drawing.Size(325, 26);
            this.MtxtFName.TabIndex = 44;
            // 
            // MtxtEmail
            // 
            this.MtxtEmail.Location = new System.Drawing.Point(698, 278);
            this.MtxtEmail.Name = "MtxtEmail";
            this.MtxtEmail.Size = new System.Drawing.Size(325, 26);
            this.MtxtEmail.TabIndex = 46;
            this.MtxtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.MtxtEmail_Validating);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(697, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Employee ID: ";
            // 
            // MtxtLName
            // 
            this.MtxtLName.Location = new System.Drawing.Point(698, 215);
            this.MtxtLName.Name = "MtxtLName";
            this.MtxtLName.Size = new System.Drawing.Size(325, 26);
            this.MtxtLName.TabIndex = 45;
            // 
            // MdtpDOB
            // 
            this.MdtpDOB.Location = new System.Drawing.Point(698, 337);
            this.MdtpDOB.Name = "MdtpDOB";
            this.MdtpDOB.Size = new System.Drawing.Size(326, 26);
            this.MdtpDOB.TabIndex = 61;
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByID.Location = new System.Drawing.Point(1057, 89);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(284, 41);
            this.btnSearchByID.TabIndex = 62;
            this.btnSearchByID.Text = "Get Info By ID";
            this.btnSearchByID.UseVisualStyleBackColor = true;
            this.btnSearchByID.Click += new System.EventHandler(this.btnSearchByID_Click);
            // 
            // lvEmpList
            // 
            this.lvEmpList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vlEmpID,
            this.vlFName,
            this.vlEmail});
            this.lvEmpList.HideSelection = false;
            this.lvEmpList.Location = new System.Drawing.Point(12, 59);
            this.lvEmpList.Name = "lvEmpList";
            this.lvEmpList.Size = new System.Drawing.Size(665, 371);
            this.lvEmpList.TabIndex = 63;
            this.lvEmpList.UseCompatibleStateImageBehavior = false;
            this.lvEmpList.View = System.Windows.Forms.View.Details;
            // 
            // vlEmpID
            // 
            this.vlEmpID.Text = "Employee ID";
            this.vlEmpID.Width = 100;
            // 
            // vlFName
            // 
            this.vlFName.Text = "Full Name";
            this.vlFName.Width = 110;
            // 
            // vlEmail
            // 
            this.vlEmail.Text = "Email";
            this.vlEmail.Width = 200;
            // 
            // btnSearchEmail
            // 
            this.btnSearchEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmail.Location = new System.Drawing.Point(1057, 136);
            this.btnSearchEmail.Name = "btnSearchEmail";
            this.btnSearchEmail.Size = new System.Drawing.Size(284, 41);
            this.btnSearchEmail.TabIndex = 64;
            this.btnSearchEmail.Text = "Search by Email";
            this.btnSearchEmail.UseVisualStyleBackColor = true;
            this.btnSearchEmail.Click += new System.EventHandler(this.btnSearchEmail_Click);
            // 
            // ManageEmpDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 452);
            this.Controls.Add(this.btnSearchEmail);
            this.Controls.Add(this.lvEmpList);
            this.Controls.Add(this.btnSearchByID);
            this.Controls.Add(this.MdtpDOB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.MtxtEmpID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MtxtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MtxtFName);
            this.Controls.Add(this.MtxtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MtxtLName);
            this.Name = "ManageEmpDetails";
            this.Text = "Manage Employee Details";
            this.Load += new System.EventHandler(this.ManageEmpDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox MtxtEmpID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MtxtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MtxtFName;
        private System.Windows.Forms.TextBox MtxtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MtxtLName;
        private System.Windows.Forms.DateTimePicker MdtpDOB;
        private System.Windows.Forms.Button btnSearchByID;
        private System.Windows.Forms.ListView lvEmpList;
        public System.Windows.Forms.ColumnHeader vlEmpID;
        public System.Windows.Forms.ColumnHeader vlFName;
        public System.Windows.Forms.ColumnHeader vlEmail;
        private System.Windows.Forms.Button btnSearchEmail;
    }
}