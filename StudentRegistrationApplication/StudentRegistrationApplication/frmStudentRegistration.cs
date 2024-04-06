using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();

            for(int i = 1900; i <= 2024; i++)
            {
                yearComboBox.Items.Add(i.ToString());
            }

            for(int i = 1; i <= 12; i++)
            {
                monthComboBox.Items.Add(i.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string gender = "";

            #region Last name warning condition
            if (lastNameBox.Text.Equals(""))
            {
                lastNameWarning.Visible = true;
            }
            else
            {
                lastNameWarning.Visible = false;
            }
            #endregion

            #region First name warning condition
            if (firstNameBox.Text.Equals(""))
            {
                firstNameWarning.Visible = true;
            }
            else
            {
                firstNameWarning.Visible = false;
            }
            #endregion

            if(maleRadioBtn.Checked)
            {
                gender = "Male";
            }else if (femaleRadioBtn.Checked)
            {
                gender = "Female";
            }

            #region Gender warning condition
            if (!maleRadioBtn.Checked && !femaleRadioBtn.Checked)
            {
                genderWarning.Visible = true;
            }
            else
            {
                genderWarning.Visible = false;
            }
            #endregion

            #region Birth Date warning condition
            if(yearComboBox.Text.Equals("-Year-") || yearComboBox.Text.Equals("")
                || monthComboBox.Text.Equals("-Month-") || monthComboBox.Text.Equals("")
                || dayComboBox.Text.Equals("-Day-") || dayComboBox.Text.Equals(""))
            {
                birthDateWarning.Visible = true;
            }
            else
            {
                birthDateWarning.Visible = false;
            }
            #endregion

            if (!firstNameWarning.Visible == true && !lastNameWarning.Visible == true && !genderWarning.Visible == true && !birthDateWarning.Visible == true)
            {
                MessageBox.Show($"Student Name: {firstNameBox.Text} {middleNameBox.Text} {lastNameBox.Text}" +
                $"\nGender: {gender}" +
                $"\nDate of birth: {dayComboBox.Text}/{monthComboBox.Text}/{yearComboBox.Text}");
            }
            
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dayComboBox.Items.Clear();

            int yearInt;
            yearInt = Convert.ToInt32(yearComboBox.SelectedItem);

            if (yearInt % 4 == 0 && monthComboBox.SelectedItem.ToString().Equals("2"))
            {
                for (int i = 1; i <= 29; i++)
                {
                    dayComboBox.Items.Add(i.ToString());
                }

            }
            else if (monthComboBox.SelectedItem.Equals("2"))
            {
                for (int i = 1; i <= 28; i++)
                {
                    dayComboBox.Items.Add(i.ToString());
                }
            }
            else
            {
                for (int i = 1; i <= 31; i++)
                {
                    dayComboBox.Items.Add(i.ToString());
                }
            }
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthComboBox.ResetText();
            dayComboBox.ResetText();
            dayComboBox.Items.Clear();
        }
    }
}
