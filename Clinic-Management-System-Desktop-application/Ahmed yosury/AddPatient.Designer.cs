﻿namespace Clinic_Management_System_Desktop_application.Ahmed_yosury
{
    partial class AddPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatient));
            this.AgeValue = new System.Windows.Forms.NumericUpDown();
            this.MaritalStatusValue = new System.Windows.Forms.ComboBox();
            this.GenderValue = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddressValue = new System.Windows.Forms.TextBox();
            this.PhoneValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.Label();
            this.IvaildAppointment = new System.Windows.Forms.Label();
            this.IvaildAge = new System.Windows.Forms.Label();
            this.Ivaildaddreess = new System.Windows.Forms.Label();
            this.IvaildPhone = new System.Windows.Forms.Label();
            this.IvaildName = new System.Windows.Forms.Label();
            this.AddAppointmentValue = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AgeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // AgeValue
            // 
            this.AgeValue.Location = new System.Drawing.Point(899, 138);
            this.AgeValue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AgeValue.Name = "AgeValue";
            this.AgeValue.Size = new System.Drawing.Size(164, 24);
            this.AgeValue.TabIndex = 89;
            // 
            // MaritalStatusValue
            // 
            this.MaritalStatusValue.FormattingEnabled = true;
            this.MaritalStatusValue.Items.AddRange(new object[] {
            "married",
            "Single",
            ""});
            this.MaritalStatusValue.Location = new System.Drawing.Point(476, 138);
            this.MaritalStatusValue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaritalStatusValue.Name = "MaritalStatusValue";
            this.MaritalStatusValue.Size = new System.Drawing.Size(163, 24);
            this.MaritalStatusValue.TabIndex = 87;
            // 
            // GenderValue
            // 
            this.GenderValue.FormattingEnabled = true;
            this.GenderValue.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderValue.Location = new System.Drawing.Point(255, 138);
            this.GenderValue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GenderValue.Name = "GenderValue";
            this.GenderValue.Size = new System.Drawing.Size(164, 24);
            this.GenderValue.TabIndex = 86;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 204);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(869, 290);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(682, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 84;
            this.label7.Text = "AddAppointment:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(888, 524);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 46);
            this.button4.TabIndex = 83;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(579, 524);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 46);
            this.button3.TabIndex = 82;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Lime;
            this.Save.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Save.Location = new System.Drawing.Point(298, 524);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(163, 46);
            this.Save.TabIndex = 81;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(472, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 80;
            this.label6.Text = "Marital Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(913, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 79;
            this.label5.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(257, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 78;
            this.label4.Text = "Gender:";
            // 
            // AddressValue
            // 
            this.AddressValue.Location = new System.Drawing.Point(686, 50);
            this.AddressValue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddressValue.Name = "AddressValue";
            this.AddressValue.Size = new System.Drawing.Size(164, 24);
            this.AddressValue.TabIndex = 77;
            // 
            // PhoneValue
            // 
            this.PhoneValue.Location = new System.Drawing.Point(476, 52);
            this.PhoneValue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PhoneValue.Name = "PhoneValue";
            this.PhoneValue.Size = new System.Drawing.Size(164, 24);
            this.PhoneValue.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(477, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 74;
            this.label2.Text = "Phone:";
            // 
            // NameValue
            // 
            this.NameValue.Location = new System.Drawing.Point(257, 50);
            this.NameValue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.NameValue.Name = "NameValue";
            this.NameValue.Size = new System.Drawing.Size(164, 24);
            this.NameValue.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(258, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 72;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(682, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 76;
            this.label3.Text = "Address:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(27, 433);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Recepitanist";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 596);
            this.panel1.TabIndex = 90;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(233, 80);
            this.panel6.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, -21);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.Logout);
            this.panel2.Location = new System.Drawing.Point(0, 524);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 71);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Visible = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Logout.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Logout.Location = new System.Drawing.Point(105, 23);
            this.Logout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(78, 28);
            this.Logout.TabIndex = 1;
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // IvaildAppointment
            // 
            this.IvaildAppointment.AutoSize = true;
            this.IvaildAppointment.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IvaildAppointment.ForeColor = System.Drawing.Color.Red;
            this.IvaildAppointment.Location = new System.Drawing.Point(698, 174);
            this.IvaildAppointment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IvaildAppointment.Name = "IvaildAppointment";
            this.IvaildAppointment.Size = new System.Drawing.Size(138, 19);
            this.IvaildAppointment.TabIndex = 103;
            this.IvaildAppointment.Text = "Chosse Appointment";
            // 
            // IvaildAge
            // 
            this.IvaildAge.AutoSize = true;
            this.IvaildAge.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IvaildAge.ForeColor = System.Drawing.Color.Red;
            this.IvaildAge.Location = new System.Drawing.Point(935, 174);
            this.IvaildAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IvaildAge.Name = "IvaildAge";
            this.IvaildAge.Size = new System.Drawing.Size(76, 19);
            this.IvaildAge.TabIndex = 101;
            this.IvaildAge.Text = "invalid Age";
            // 
            // Ivaildaddreess
            // 
            this.Ivaildaddreess.AutoSize = true;
            this.Ivaildaddreess.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ivaildaddreess.ForeColor = System.Drawing.Color.Red;
            this.Ivaildaddreess.Location = new System.Drawing.Point(718, 86);
            this.Ivaildaddreess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ivaildaddreess.Name = "Ivaildaddreess";
            this.Ivaildaddreess.Size = new System.Drawing.Size(94, 19);
            this.Ivaildaddreess.TabIndex = 100;
            this.Ivaildaddreess.Text = "Enter Address";
            // 
            // IvaildPhone
            // 
            this.IvaildPhone.AutoSize = true;
            this.IvaildPhone.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IvaildPhone.ForeColor = System.Drawing.Color.Red;
            this.IvaildPhone.Location = new System.Drawing.Point(489, 87);
            this.IvaildPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IvaildPhone.Name = "IvaildPhone";
            this.IvaildPhone.Size = new System.Drawing.Size(160, 19);
            this.IvaildPhone.TabIndex = 99;
            this.IvaildPhone.Text = "invalid Num, Must be 11";
            // 
            // IvaildName
            // 
            this.IvaildName.AutoSize = true;
            this.IvaildName.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IvaildName.ForeColor = System.Drawing.Color.Red;
            this.IvaildName.Location = new System.Drawing.Point(295, 85);
            this.IvaildName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IvaildName.Name = "IvaildName";
            this.IvaildName.Size = new System.Drawing.Size(81, 19);
            this.IvaildName.TabIndex = 97;
            this.IvaildName.Text = "Enter Name";
            // 
            // AddAppointmentValue
            // 
            this.AddAppointmentValue.Location = new System.Drawing.Point(686, 139);
            this.AddAppointmentValue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddAppointmentValue.Name = "AddAppointmentValue";
            this.AddAppointmentValue.Size = new System.Drawing.Size(164, 24);
            this.AddAppointmentValue.TabIndex = 104;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(997, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 105;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 594);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.AddAppointmentValue);
            this.Controls.Add(this.IvaildAppointment);
            this.Controls.Add(this.IvaildAge);
            this.Controls.Add(this.Ivaildaddreess);
            this.Controls.Add(this.IvaildPhone);
            this.Controls.Add(this.IvaildName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AgeValue);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.MaritalStatusValue);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.GenderValue);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddressValue);
            this.Controls.Add(this.PhoneValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "AddPatient";
            this.Text = "AddPatient";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown AgeValue;
        private System.Windows.Forms.ComboBox MaritalStatusValue;
        private System.Windows.Forms.ComboBox GenderValue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddressValue;
        private System.Windows.Forms.TextBox PhoneValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.Label IvaildAppointment;
        private System.Windows.Forms.Label IvaildAge;
        private System.Windows.Forms.Label Ivaildaddreess;
        private System.Windows.Forms.Label IvaildPhone;
        private System.Windows.Forms.Label IvaildName;
        private System.Windows.Forms.DateTimePicker AddAppointmentValue;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}