using HRTJ.Base;
namespace HRTJ
{
    partial class Frm_NK1
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
            this.CtlUserInfro = new HRTJ.Base.UserControlInfor();
            this.userControl_NK11 = new HRTJ.Base.UserControl_NK1();
            this.SuspendLayout();
            // 
            // CtlUserInfro
            // 
            this.CtlUserInfro.Dock = System.Windows.Forms.DockStyle.Top;
            this.CtlUserInfro.ID = null;
            this.CtlUserInfro.Location = new System.Drawing.Point(0, 0);
            this.CtlUserInfro.Name = "CtlUserInfro";
            this.CtlUserInfro.Size = new System.Drawing.Size(613, 185);
            this.CtlUserInfro.TabIndex = 1;
            // 
            // userControl_NK11
            // 
            this.userControl_NK11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_NK11.ID = null;
            this.userControl_NK11.Location = new System.Drawing.Point(0, 185);
            this.userControl_NK11.Name = "userControl_NK11";
            this.userControl_NK11.Size = new System.Drawing.Size(613, 202);
            this.userControl_NK11.TabIndex = 2;
            // 
            // Frm_NK1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 445);
            this.Controls.Add(this.userControl_NK11);
            this.Controls.Add(this.CtlUserInfro);
            this.Name = "Frm_NK1";
            this.Text = "内科 ①";
            this.Controls.SetChildIndex(this.CtlUserInfro, 0);
            this.Controls.SetChildIndex(this.userControl_NK11, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlInfor CtlUserInfro;
        private Base.UserControl_NK1 userControl_NK11;
    }
}