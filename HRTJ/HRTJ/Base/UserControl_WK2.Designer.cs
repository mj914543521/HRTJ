namespace HRTJ.Base
{
    partial class UserControl_WK2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckb_fhl = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fhl = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentexamDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckb_fhl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_fhl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "体检信息--外科②";
            // 
            // ckb_fhl
            // 
            this.ckb_fhl.AutoSize = true;
            this.ckb_fhl.Location = new System.Drawing.Point(186, 34);
            this.ckb_fhl.Name = "ckb_fhl";
            this.ckb_fhl.Size = new System.Drawing.Size(72, 16);
            this.ckb_fhl.TabIndex = 2;
            this.ckb_fhl.Text = "暂未检测";
            this.ckb_fhl.UseVisualStyleBackColor = true;
            this.ckb_fhl.CheckedChanged += new System.EventHandler(this.ckb_fhl_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "ML";
            // 
            // txt_fhl
            // 
            this.txt_fhl.Location = new System.Drawing.Point(70, 31);
            this.txt_fhl.Mask = "99999";
            this.txt_fhl.Name = "txt_fhl";
            this.txt_fhl.Size = new System.Drawing.Size(81, 21);
            this.txt_fhl.TabIndex = 1;
            this.txt_fhl.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "肺活量";
            // 
            // UserControl_WK2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl_WK2";
            this.Size = new System.Drawing.Size(347, 82);
            ((System.ComponentModel.ISupportInitialize)(this.studentexamDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox txt_fhl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckb_fhl;
    }
}
