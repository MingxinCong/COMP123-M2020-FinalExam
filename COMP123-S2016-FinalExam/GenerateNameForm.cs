using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
 /**
 * File Name: GenerateNameForm.cs
 * Author: Mingxin Cong
 * Student ID: 301130476
 * Changes Made: created the file and added a few methods
 */
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void GenerateNames(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int indexOfFirstName = rnd.Next(0, firstNameListBox.Items.Count);
            firstNameTextBox.Text = firstNameListBox.Items[indexOfFirstName].ToString();
            int indexOfLastName = rnd.Next(0, lastNameListBox.Items.Count);
            lastNameTextBox.Text = lastNameListBox.Items[indexOfLastName].ToString();
            Program.character.FirstName = firstNameTextBox.Text;
            Program.character.LastName = lastNameListBox.Text;
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames(sender, e);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.abilityGeneratorForm = new AbilityGeneratorForm();
            Program.abilityGeneratorForm.Show();
            Hide();
        }
    }
}
