﻿using System;
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
 * File Name: FinalForm.cs
 * Author: Mingxin Cong
 * Student ID: 301130476
 * Changes Made: created the file and finish all the methods at the same time
 */
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
        // event handler for menu button exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // event handler for form load event, populating data to textboxes
        private void FinalForm_Load(object sender, EventArgs e)
        {
            var character = Program.character;
            CharismaTextBox.Text = character.Charisma;
            WisdomTextBox.Text = character.Wisdom;
            IntelligenceTextBox.Text = character.Intelligence;
            ConstitutionTextBox.Text = character.Constitution;
            DexterityTextBox.Text = character.Dexterity;
            StrengthTextBox.Text = character.Strength;
            FirstNameTextBox.Text = character.FirstName;
            LastNameTextBox.Text = character.LastName;
            RaceTextBox.Text = character.Race;
        }
    }
}
