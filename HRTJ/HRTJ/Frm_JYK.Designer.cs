using HRTJ.Base;
namespace HRTJ
{
    partial class Frm_JYK
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
            this.CtlUserInfro = new UserControlInfor();
            this.userControl_TYK1 = new HRTJ.Base.UserControl_JYK();
            this.SuspendLayout();
            // 
            // CtlUserInfro
            // 
            this.CtlUserInfro.Dock = System.Windows.Forms.DockStyle.Top;
            this.CtlUserInfro.Location = new System.Drawing.Point(0, 0);
            this.CtlUserInfro.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CtlUserInfro.Name = "CtlUserInfro";
            this.CtlUserInfro.Size = new System.Drawing.Size(790, 277);
            this.CtlUserInfro.TabIndex = 0;
            
            // 
            // userControl_TYK1
            // 
            this.userControl_TYK1.BackColor = System.Drawing.Color.Transparent;
            this.userControl_TYK1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_TYK1.Location = new System.Drawing.Point(0, 277);
            this.userControl_TYK1.Name = "userControl_TYK1";
            this.userControl_TYK1.Size = new System.Drawing.Size(790, 120);
            this.userControl_TYK1.TabIndex = 1;
            // 
            // Frm_JYK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 469);
            this.Controls.Add(this.userControl_TYK1);
            this.Controls.Add(this.CtlUserInfro);
            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_JYK";
            this.Text = "检验科";
            this.Controls.SetChildIndex(this.CtlUserInfro, 0);
            this.Controls.SetChildIndex(this.userControl_TYK1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlInfor CtlUserInfro;
        private Base.UserControl_JYK userControl_TYK1;
    }
}