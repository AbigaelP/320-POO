﻿namespace Drones
{
    partial class AirSpace
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ticker = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ticker
            // 
            ticker.Enabled = true;
            ticker.Tick += NewFrame;
            // 
            // AirSpace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 530);
            Name = "AirSpace";
            Text = "AirSpace";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer ticker;
    }
}