namespace HRTJ.Base
{
    partial class UserControl_XXXX
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_TJK = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tab_KQK = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tab_YK = new System.Windows.Forms.TabPage();
            this.tab_NK = new System.Windows.Forms.TabPage();
            this.tab_WK = new System.Windows.Forms.TabPage();
            this.userControl_JYK1 = new HRTJ.Base.UserControl_JYK();
            this.userControl_KQK1 = new HRTJ.Base.UserControl_KQK();
            this.userControl_YK21 = new HRTJ.Base.UserControl_YK2();
            this.userControl_YK11 = new HRTJ.Base.UserControl_YK1();
            this.userControl_NK21 = new HRTJ.Base.UserControl_NK2();
            this.userControl_NK11 = new HRTJ.Base.UserControl_NK1();
            this.userControl_WK21 = new HRTJ.Base.UserControl_WK2();
            this.userControl_WK11 = new HRTJ.Base.UserControl_WK1();
            this.tabControl1.SuspendLayout();
            this.tab_TJK.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tab_KQK.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tab_YK.SuspendLayout();
            this.tab_NK.SuspendLayout();
            this.tab_WK.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_TJK);
            this.tabControl1.Controls.Add(this.tab_KQK);
            this.tabControl1.Controls.Add(this.tab_YK);
            this.tabControl1.Controls.Add(this.tab_NK);
            this.tabControl1.Controls.Add(this.tab_WK);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_TJK
            // 
            this.tab_TJK.Controls.Add(this.panel2);
            this.tab_TJK.Location = new System.Drawing.Point(4, 22);
            this.tab_TJK.Name = "tab_TJK";
            this.tab_TJK.Padding = new System.Windows.Forms.Padding(3);
            this.tab_TJK.Size = new System.Drawing.Size(787, 432);
            this.tab_TJK.TabIndex = 0;
            this.tab_TJK.Text = "体验科";
            this.tab_TJK.UseVisualStyleBackColor = true;
            this.tab_TJK.Click += new System.EventHandler(this.tab_TJK_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userControl_JYK1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 426);
            this.panel2.TabIndex = 2;
            // 
            // tab_KQK
            // 
            this.tab_KQK.Controls.Add(this.panel4);
            this.tab_KQK.Location = new System.Drawing.Point(4, 22);
            this.tab_KQK.Name = "tab_KQK";
            this.tab_KQK.Padding = new System.Windows.Forms.Padding(3);
            this.tab_KQK.Size = new System.Drawing.Size(787, 432);
            this.tab_KQK.TabIndex = 1;
            this.tab_KQK.Text = "口腔科";
            this.tab_KQK.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.userControl_KQK1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(781, 426);
            this.panel4.TabIndex = 3;
            // 
            // tab_YK
            // 
            this.tab_YK.Controls.Add(this.userControl_YK21);
            this.tab_YK.Controls.Add(this.userControl_YK11);
            this.tab_YK.Location = new System.Drawing.Point(4, 22);
            this.tab_YK.Name = "tab_YK";
            this.tab_YK.Size = new System.Drawing.Size(787, 432);
            this.tab_YK.TabIndex = 4;
            this.tab_YK.Text = "眼科";
            this.tab_YK.UseVisualStyleBackColor = true;
            // 
            // tab_NK
            // 
            this.tab_NK.Controls.Add(this.userControl_NK21);
            this.tab_NK.Controls.Add(this.userControl_NK11);
            this.tab_NK.Location = new System.Drawing.Point(4, 22);
            this.tab_NK.Name = "tab_NK";
            this.tab_NK.Size = new System.Drawing.Size(787, 432);
            this.tab_NK.TabIndex = 2;
            this.tab_NK.Text = "内科";
            this.tab_NK.UseVisualStyleBackColor = true;
            // 
            // tab_WK
            // 
            this.tab_WK.Controls.Add(this.userControl_WK21);
            this.tab_WK.Controls.Add(this.userControl_WK11);
            this.tab_WK.Location = new System.Drawing.Point(4, 22);
            this.tab_WK.Name = "tab_WK";
            this.tab_WK.Size = new System.Drawing.Size(787, 432);
            this.tab_WK.TabIndex = 3;
            this.tab_WK.Text = "外科";
            this.tab_WK.UseVisualStyleBackColor = true;
            // 
            // userControl_JYK1
            // 
            this.userControl_JYK1.BackColor = System.Drawing.Color.Transparent;
            this.userControl_JYK1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControl_JYK1.ID = null;
            this.userControl_JYK1.Location = new System.Drawing.Point(0, 0);
            this.userControl_JYK1.Name = "userControl_JYK1";
            this.userControl_JYK1.Size = new System.Drawing.Size(781, 110);
            this.userControl_JYK1.TabIndex = 0;
            // 
            // userControl_KQK1
            // 
            this.userControl_KQK1.ID = null;
            this.userControl_KQK1.Location = new System.Drawing.Point(4, 7);
            this.userControl_KQK1.Name = "userControl_KQK1";
            this.userControl_KQK1.Size = new System.Drawing.Size(784, 421);
            this.userControl_KQK1.TabIndex = 0;
            // 
            // userControl_YK21
            // 
            this.userControl_YK21.ID = null;
            this.userControl_YK21.Location = new System.Drawing.Point(4, 132);
            this.userControl_YK21.Name = "userControl_YK21";
            this.userControl_YK21.Size = new System.Drawing.Size(442, 160);
            this.userControl_YK21.TabIndex = 1;
            // 
            // userControl_YK11
            // 
            this.userControl_YK11.ID = null;
            this.userControl_YK11.Location = new System.Drawing.Point(0, 3);
            this.userControl_YK11.Name = "userControl_YK11";
            this.userControl_YK11.Size = new System.Drawing.Size(618, 122);
            this.userControl_YK11.TabIndex = 0;
            // 
            // userControl_NK21
            // 
            this.userControl_NK21.ID = null;
            this.userControl_NK21.Location = new System.Drawing.Point(4, 185);
            this.userControl_NK21.Name = "userControl_NK21";
            this.userControl_NK21.Size = new System.Drawing.Size(396, 131);
            this.userControl_NK21.TabIndex = 1;
            // 
            // userControl_NK11
            // 
            this.userControl_NK11.ID = null;
            this.userControl_NK11.Location = new System.Drawing.Point(4, 4);
            this.userControl_NK11.Name = "userControl_NK11";
            this.userControl_NK11.Size = new System.Drawing.Size(396, 165);
            this.userControl_NK11.TabIndex = 0;
            // 
            // userControl_WK21
            // 
            this.userControl_WK21.ID = null;
            this.userControl_WK21.Location = new System.Drawing.Point(4, 193);
            this.userControl_WK21.Name = "userControl_WK21";
            this.userControl_WK21.Size = new System.Drawing.Size(671, 82);
            this.userControl_WK21.TabIndex = 1;
            // 
            // userControl_WK11
            // 
            this.userControl_WK11.ID = null;
            this.userControl_WK11.Location = new System.Drawing.Point(4, 4);
            this.userControl_WK11.Name = "userControl_WK11";
            this.userControl_WK11.Size = new System.Drawing.Size(671, 182);
            this.userControl_WK11.TabIndex = 0;
            // 
            // UserControl_XXXX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControl_XXXX";
            this.Size = new System.Drawing.Size(795, 458);
            this.tabControl1.ResumeLayout(false);
            this.tab_TJK.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tab_KQK.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tab_YK.ResumeLayout(false);
            this.tab_NK.ResumeLayout(false);
            this.tab_WK.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_TJK;
        private System.Windows.Forms.TabPage tab_KQK;
        private System.Windows.Forms.TabPage tab_YK;
        private System.Windows.Forms.TabPage tab_NK;
        private System.Windows.Forms.TabPage tab_WK;
        private UserControl_JYK userControl_JYK1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private UserControl_KQK userControl_KQK1;
        private UserControl_YK2 userControl_YK21;
        private UserControl_YK1 userControl_YK11;
        private UserControl_NK2 userControl_NK21;
        private UserControl_NK1 userControl_NK11;
        private UserControl_WK2 userControl_WK21;
        private UserControl_WK1 userControl_WK11;
    }
}
