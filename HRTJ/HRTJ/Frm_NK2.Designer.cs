﻿using HRTJ.Base;
namespace HRTJ
{
    partial class Frm_NK2
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
            this.userControlInfor1 = new HRTJ.Base.UserControlInfor();
            this.userControl_NK21 = new HRTJ.Base.UserControl_NK2();
            this.SuspendLayout();
            // 
            // userControlInfor1
            // 
            this.userControlInfor1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControlInfor1.ID = null;
            this.userControlInfor1.Location = new System.Drawing.Point(0, 0);
            this.userControlInfor1.Name = "userControlInfor1";
            this.userControlInfor1.Size = new System.Drawing.Size(626, 165);
            this.userControlInfor1.TabIndex = 1;
            // 
            // userControl_NK21
            // 
            this.userControl_NK21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_NK21.ID = null;
            this.userControl_NK21.Location = new System.Drawing.Point(0, 165);
            this.userControl_NK21.Name = "userControl_NK21";
            this.userControl_NK21.Size = new System.Drawing.Size(626, 76);
            this.userControl_NK21.TabIndex = 2;
            // 
            // Frm_NK2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 359);
            this.Controls.Add(this.userControl_NK21);
            this.Controls.Add(this.userControlInfor1);
            this.Name = "Frm_NK2";
            this.Text = "内科 ②";
            this.Controls.SetChildIndex(this.userControlInfor1, 0);
            this.Controls.SetChildIndex(this.userControl_NK21, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlInfor userControlInfor1;
        private Base.UserControl_NK2 userControl_NK21;
    }
}