using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Personal_Information
{
    public partial class PersonalInformationForm : Form
    {
        public PersonalInformationForm()
        {
            InitializeComponent();
        }

        string firstName = "";
        string lastName = "";
        string fateherName = "";
        string motherName = "";
        string pAddress = "";

        private void saveButton_Click(object sender, EventArgs e)
        {
            firstName = firstNametextBox.Text;
            lastName = lastNameTextBox.Text;
            fateherName = fatherNameTextBox.Text;
            motherName = mothersNameTextBox.Text;
            pAddress = addressTextBox.Text;

            firstNametextBox.Text= "";
            lastNameTextBox.Text = "";
            fatherNameTextBox.Text = "";
            mothersNameTextBox.Text = "";
            addressTextBox.Text = "";
        }

        private void showInformationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Your Name : " + firstName + " " + lastName + 
                             "\n Father's Name : " + fateherName +
                             "\n Mother's Name : " + motherName +
                             "\n Your Address : " + pAddress);
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Your Name : " + firstName + " " + lastName);
        }

        private void parentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Father's Name : " + fateherName +
                            "\n Mother's Name : " + motherName);
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Address : " + pAddress);
        }

    }
}
