namespace HRTJ
{
    partial class Frm_XXXX
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
            this.userControl_XXXX1 = new HRTJ.Base.UserControl_XXXX();
            this.userControlInfor1 = new HRTJ.Base.UserControlInfor();
            this.SuspendLayout();
            // 
            // userControl_XXXX1
            // 
            this.userControl_XXXX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_XXXX1.Location = new System.Drawing.Point(0, 153);
            this.userControl_XXXX1.Name = "userControl_XXXX1";
            this.userControl_XXXX1.Size = new System.Drawing.Size(849, 447);
            this.userControl_XXXX1.TabIndex = 1;
            // 
            // userControlInfor1
            // 
            this.userControlInfor1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControlInfor1.ID = null;
            this.userControlInfor1.Location = new System.Drawing.Point(0, 0);
            this.userControlInfor1.Name = "userControlInfor1";
            this.userControlInfor1.Size = new System.Drawing.Size(849, 153);
            this.userControlInfor1.TabIndex = 0;
            // 
            // Frm_XXXX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 680);
            this.Controls.Add(this.userControl_XXXX1);
            this.Controls.Add(this.userControlInfor1);
            this.Name = "Frm_XXXX";
            this.Text = "详细信息";
            this.ResumeLayout(false);

        }

        #endregion

        private Base.UserControlInfor userControlInfor1;
        private Base.UserControl_XXXX userControl_XXXX1;

    }
}