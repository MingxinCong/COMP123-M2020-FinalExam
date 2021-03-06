﻿namespace COMP123_M2020_FinalExam
{/**
 * File Name: SplashForm.cs
 * Author: Mingxin Cong
 * Student ID: 301130476
 * Changes Made: added timer and various properties
 */
    // SplashForm is responsible for showing the starting screen for 3 seconds
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            this.splashFormTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // splashFormTimer
            // 
            this.splashFormTimer.Enabled = true;
            this.splashFormTimer.Interval = 3000;
            this.splashFormTimer.Tick += new System.EventHandler(this.splashFormTimer_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COMP123_M2020_FinalExam.Properties.Resources.splashSceen;
            this.ClientSize = new System.Drawing.Size(582, 273);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer splashFormTimer;
    }
}