using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * File Name: SplashForm.cs
 * Author: Mingxin Cong
 * Student ID: 301130476
 * Changes Made: created the file and finish at the same time
 */
namespace COMP123_M2020_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        // event handler for timer elapse
        private void splashFormTimer_Tick(object sender, EventArgs e)
        {
            Program.generateNameForm.Show();
            Hide();
            splashFormTimer.Enabled = false;
        }
    }
}
