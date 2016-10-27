namespace FirstAssignmentDatabases
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
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstContacts = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNr = new System.Windows.Forms.TextBox();
            this.lblPhoneNr = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtPostNr = new System.Windows.Forms.TextBox();
            this.lblPostnr = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstContacts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacts";
            // 
            // lstContacts
            // 
            this.lstContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstContacts.Location = new System.Drawing.Point(3, 16);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(122, 218);
            this.lstContacts.TabIndex = 0;
            this.lstContacts.UseCompatibleStateImageBehavior = false;
            this.lstContacts.View = System.Windows.Forms.View.List;
            this.lstContacts.SelectedIndexChanged += new System.EventHandler(this.lstContacts_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdDelete);
            this.groupBox2.Controls.Add(this.cmdEdit);
            this.groupBox2.Controls.Add(this.cmdSave);
            this.groupBox2.Controls.Add(this.dtpBirthday);
            this.groupBox2.Controls.Add(this.lblBirthday);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtPhoneNr);
            this.groupBox2.Controls.Add(this.lblPhoneNr);
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Controls.Add(this.lblCity);
            this.groupBox2.Controls.Add(this.txtPostNr);
            this.groupBox2.Controls.Add(this.lblPostnr);
            this.groupBox2.Controls.Add(this.txtAdress);
            this.groupBox2.Controls.Add(this.lblAdress);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(146, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 234);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Person Info";
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(177, 205);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 14;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(96, 205);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(75, 23);
            this.cmdEdit.TabIndex = 13;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(15, 205);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 12;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(94, 170);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(170, 20);
            this.dtpBirthday.TabIndex = 11;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(6, 174);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(51, 13);
            this.lblBirthday.TabIndex = 10;
            this.lblBirthday.Text = "Birthday: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(94, 144);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 147);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email: ";
            // 
            // txtPhoneNr
            // 
            this.txtPhoneNr.Location = new System.Drawing.Point(94, 118);
            this.txtPhoneNr.Name = "txtPhoneNr";
            this.txtPhoneNr.Size = new System.Drawing.Size(170, 20);
            this.txtPhoneNr.TabIndex = 7;
            // 
            // lblPhoneNr
            // 
            this.lblPhoneNr.AutoSize = true;
            this.lblPhoneNr.Location = new System.Drawing.Point(6, 121);
            this.lblPhoneNr.Name = "lblPhoneNr";
            this.lblPhoneNr.Size = new System.Drawing.Size(84, 13);
            this.lblPhoneNr.TabIndex = 6;
            this.lblPhoneNr.Text = "Phone Number: ";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(94, 91);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(170, 20);
            this.txtCity.TabIndex = 5;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 94);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City: ";
            // 
            // txtPostNr
            // 
            this.txtPostNr.Location = new System.Drawing.Point(94, 65);
            this.txtPostNr.Name = "txtPostNr";
            this.txtPostNr.Size = new System.Drawing.Size(170, 20);
            this.txtPostNr.TabIndex = 5;
            // 
            // lblPostnr
            // 
            this.lblPostnr.AutoSize = true;
            this.lblPostnr.Location = new System.Drawing.Point(6, 68);
            this.lblPostnr.Name = "lblPostnr";
            this.lblPostnr.Size = new System.Drawing.Size(71, 13);
            this.lblPostnr.TabIndex = 4;
            this.lblPostnr.Text = "Post Number:";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(94, 39);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(170, 20);
            this.txtAdress.TabIndex = 3;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(6, 42);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(45, 13);
            this.lblAdress.TabIndex = 2;
            this.lblAdress.Text = "Adress: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 20);
            this.txtName.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 258);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Adress Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstContacts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPostNr;
        private System.Windows.Forms.Label lblPostnr;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNr;
        private System.Windows.Forms.Label lblPhoneNr;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdSave;
    }
}

