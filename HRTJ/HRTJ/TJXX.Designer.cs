namespace HRTJ
{
    partial class TJXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TJXX));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Export = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xxxx = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_SysData = new System.Windows.Forms.ToolStripButton();
            this.userControl_TJXX1 = new HRTJ.Base.UserControl_TJXX();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.toolStripSeparator3,
            this.tsb_Export,
            this.toolStripSeparator5,
            this.tsb_xxxx,
            this.toolStripSeparator1,
            this.btn_SysData,
            this.toolStripSeparator4,
            this.Clear,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(852, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(35, 22);
            this.Save.Text = "录入";
            this.Save.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_Export
            // 
            this.tsb_Export.BackColor = System.Drawing.Color.Transparent;
            this.tsb_Export.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tsb_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Export.Name = "tsb_Export";
            this.tsb_Export.Size = new System.Drawing.Size(35, 22);
            this.tsb_Export.Text = "导出";
            this.tsb_Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_xxxx
            // 
            this.tsb_xxxx.BackColor = System.Drawing.Color.Transparent;
            this.tsb_xxxx.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tsb_xxxx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_xxxx.Name = "tsb_xxxx";
            this.tsb_xxxx.Size = new System.Drawing.Size(61, 22);
            this.tsb_xxxx.Text = "详细信息";
            this.tsb_xxxx.Click += new System.EventHandler(this.tsb_xxxx_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Transparent;
            this.Clear.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(35, 22);
            this.Clear.Text = "退出";
            this.Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_SysData
            // 
            this.btn_SysData.BackColor = System.Drawing.Color.Transparent;
            this.btn_SysData.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.btn_SysData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SysData.Name = "btn_SysData";
            this.btn_SysData.Size = new System.Drawing.Size(61, 22);
            this.btn_SysData.Text = "同步数据";
            this.btn_SysData.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_SysData.Click += new System.EventHandler(this.SysData_Click);
            // 
            // userControl_TJXX1
            // 
            this.userControl_TJXX1.BackColor = System.Drawing.Color.Transparent;
            this.userControl_TJXX1.DataGridKey = null;
            this.userControl_TJXX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_TJXX1.ID = null;
            this.userControl_TJXX1.Location = new System.Drawing.Point(0, 25);
            this.userControl_TJXX1.Name = "userControl_TJXX1";
            this.userControl_TJXX1.Size = new System.Drawing.Size(852, 298);
            this.userControl_TJXX1.TabIndex = 1;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // TJXX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(852, 323);
            this.Controls.Add(this.userControl_TJXX1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TJXX";
            this.Text = "体检信息";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TJXX_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Base.UserControl_TJXX userControl_TJXX1;
        private System.Windows.Forms.ToolStripButton tsb_xxxx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_Export;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btn_SysData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}