namespace StudentRegistrationApplication
{
    partial class frmStudentRegistration
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
            this.StudentRegLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.DisclaimerLabel = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.middleNameBox = new System.Windows.Forms.TextBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.maleRadioBtn = new System.Windows.Forms.RadioButton();
            this.femaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lastNameWarning = new System.Windows.Forms.Label();
            this.firstNameWarning = new System.Windows.Forms.Label();
            this.genderWarning = new System.Windows.Forms.Label();
            this.birthDateWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentRegLabel
            // 
            this.StudentRegLabel.AutoSize = true;
            this.StudentRegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentRegLabel.Location = new System.Drawing.Point(29, 9);
            this.StudentRegLabel.Name = "StudentRegLabel";
            this.StudentRegLabel.Size = new System.Drawing.Size(252, 24);
            this.StudentRegLabel.TabIndex = 0;
            this.StudentRegLabel.Text = "Student Registration Form";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(12, 82);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(107, 20);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name *";
            // 
            // DisclaimerLabel
            // 
            this.DisclaimerLabel.AutoSize = true;
            this.DisclaimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisclaimerLabel.Location = new System.Drawing.Point(13, 57);
            this.DisclaimerLabel.Name = "DisclaimerLabel";
            this.DisclaimerLabel.Size = new System.Drawing.Size(225, 16);
            this.DisclaimerLabel.TabIndex = 2;
            this.DisclaimerLabel.Text = "Note: Fields with (*) are required to fill";
            // 
            // lastNameBox
            // 
            this.lastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(16, 105);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(229, 26);
            this.lastNameBox.TabIndex = 3;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 148);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(108, 20);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = "First Name *";
            // 
            // firstNameBox
            // 
            this.firstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(16, 171);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(229, 26);
            this.firstNameBox.TabIndex = 5;
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleNameLabel.Location = new System.Drawing.Point(12, 218);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(112, 20);
            this.MiddleNameLabel.TabIndex = 6;
            this.MiddleNameLabel.Text = "Middle Name";
            // 
            // middleNameBox
            // 
            this.middleNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middleNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameBox.Location = new System.Drawing.Point(16, 241);
            this.middleNameBox.Name = "middleNameBox";
            this.middleNameBox.Size = new System.Drawing.Size(229, 26);
            this.middleNameBox.TabIndex = 7;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(12, 288);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(81, 20);
            this.GenderLabel.TabIndex = 8;
            this.GenderLabel.Text = "Gender *";
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadioBtn.Location = new System.Drawing.Point(16, 311);
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Size = new System.Drawing.Size(61, 24);
            this.maleRadioBtn.TabIndex = 9;
            this.maleRadioBtn.TabStop = true;
            this.maleRadioBtn.Text = "Male";
            this.maleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioBtn.Location = new System.Drawing.Point(83, 311);
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Size = new System.Drawing.Size(80, 24);
            this.femaleRadioBtn.TabIndex = 10;
            this.femaleRadioBtn.TabStop = true;
            this.femaleRadioBtn.Text = "Female";
            this.femaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDateLabel.Location = new System.Drawing.Point(12, 352);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(124, 20);
            this.BirthDateLabel.TabIndex = 11;
            this.BirthDateLabel.Text = "Date of Birth *";
            // 
            // yearComboBox
            // 
            this.yearComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(16, 375);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(91, 28);
            this.yearComboBox.TabIndex = 12;
            this.yearComboBox.Text = "-Year-";
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.yearComboBox_SelectedIndexChanged);
            // 
            // monthComboBox
            // 
            this.monthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(113, 375);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(89, 28);
            this.monthComboBox.TabIndex = 13;
            this.monthComboBox.Text = "-Month-";
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.monthComboBox_SelectedIndexChanged);
            // 
            // dayComboBox
            // 
            this.dayComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Location = new System.Drawing.Point(208, 375);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(91, 28);
            this.dayComboBox.TabIndex = 14;
            this.dayComboBox.Text = "-Day-";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Register Student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastNameWarning
            // 
            this.lastNameWarning.AutoSize = true;
            this.lastNameWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameWarning.ForeColor = System.Drawing.Color.Red;
            this.lastNameWarning.Location = new System.Drawing.Point(116, 82);
            this.lastNameWarning.Name = "lastNameWarning";
            this.lastNameWarning.Size = new System.Drawing.Size(177, 16);
            this.lastNameWarning.TabIndex = 16;
            this.lastNameWarning.Text = "Last Name cannot be empty!";
            this.lastNameWarning.Visible = false;
            // 
            // firstNameWarning
            // 
            this.firstNameWarning.AutoSize = true;
            this.firstNameWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameWarning.ForeColor = System.Drawing.Color.Red;
            this.firstNameWarning.Location = new System.Drawing.Point(116, 151);
            this.firstNameWarning.Name = "firstNameWarning";
            this.firstNameWarning.Size = new System.Drawing.Size(177, 16);
            this.firstNameWarning.TabIndex = 17;
            this.firstNameWarning.Text = "First Name cannot be empty!";
            this.firstNameWarning.Visible = false;
            // 
            // genderWarning
            // 
            this.genderWarning.AutoSize = true;
            this.genderWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderWarning.ForeColor = System.Drawing.Color.Red;
            this.genderWarning.Location = new System.Drawing.Point(99, 291);
            this.genderWarning.Name = "genderWarning";
            this.genderWarning.Size = new System.Drawing.Size(157, 16);
            this.genderWarning.TabIndex = 18;
            this.genderWarning.Text = "Gender cannot be empty!";
            this.genderWarning.Visible = false;
            // 
            // birthDateWarning
            // 
            this.birthDateWarning.AutoSize = true;
            this.birthDateWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateWarning.ForeColor = System.Drawing.Color.Red;
            this.birthDateWarning.Location = new System.Drawing.Point(133, 352);
            this.birthDateWarning.Name = "birthDateWarning";
            this.birthDateWarning.Size = new System.Drawing.Size(170, 16);
            this.birthDateWarning.TabIndex = 19;
            this.birthDateWarning.Text = "Birth Date cannot be empty!";
            this.birthDateWarning.Visible = false;
            // 
            // frmStudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 481);
            this.Controls.Add(this.birthDateWarning);
            this.Controls.Add(this.genderWarning);
            this.Controls.Add(this.firstNameWarning);
            this.Controls.Add(this.lastNameWarning);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dayComboBox);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.femaleRadioBtn);
            this.Controls.Add(this.maleRadioBtn);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.middleNameBox);
            this.Controls.Add(this.MiddleNameLabel);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.DisclaimerLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.StudentRegLabel);
            this.Name = "frmStudentRegistration";
            this.Text = "Student Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentRegLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label DisclaimerLabel;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.TextBox middleNameBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.RadioButton maleRadioBtn;
        private System.Windows.Forms.RadioButton femaleRadioBtn;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lastNameWarning;
        private System.Windows.Forms.Label firstNameWarning;
        private System.Windows.Forms.Label genderWarning;
        private System.Windows.Forms.Label birthDateWarning;
    }
}

