using HRTJ.Base;
namespace HRTJ
{
    partial class Frm_KQK
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userControl_YK1 = new HRTJ.Base.UserControl_KQK();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CtlUserInfro
            // 
            this.CtlUserInfro.BackColor = System.Drawing.Color.Transparent;
            this.CtlUserInfro.Dock = System.Windows.Forms.DockStyle.Top;
            this.CtlUserInfro.ID = null;
            this.CtlUserInfro.Location = new System.Drawing.Point(0, 0);
            this.CtlUserInfro.Name = "CtlUserInfro";
            this.CtlUserInfro.Size = new System.Drawing.Size(790, 158);
            this.CtlUserInfro.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userControl_YK1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 438);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "体检信息";
            // 
            // userControl_YK1
            // 
            this.userControl_YK1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_YK1.ID = null;
            this.userControl_YK1.Location = new System.Drawing.Point(3, 17);
            this.userControl_YK1.Name = "userControl_YK1";
            this.userControl_YK1.Size = new System.Drawing.Size(784, 418);
            this.userControl_YK1.TabIndex = 0;
            // 
            // Frm_KQK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 654);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CtlUserInfro);
            this.Name = "Frm_KQK";
            this.Text = "口腔科";
            this.Load += new System.EventHandler(this.Frm_KQK_Load);
            this.Controls.SetChildIndex(this.CtlUserInfro, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlInfor CtlUserInfro;
        private System.Windows.Forms.GroupBox groupBox2;
        private Base.UserControl_KQK userControl_YK1;
    }
}