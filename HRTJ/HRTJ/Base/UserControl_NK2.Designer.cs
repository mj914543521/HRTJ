namespace HRTJ.Base
{
    partial class UserControl_NK2
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
            this.ckb_szy1 = new System.Windows.Forms.CheckBox();
            this.txt_szy1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ckb_ssy1 = new System.Windows.Forms.CheckBox();
            this.txt_ssy1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentexamDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckb_szy1);
            this.groupBox1.Controls.Add(this.txt_szy1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ckb_ssy1);
            this.groupBox1.Controls.Add(this.txt_ssy1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "体检信息--内科②";
            // 
            // ckb_szy1
            // 
            this.ckb_szy1.AutoSize = true;
            this.ckb_szy1.Location = new System.Drawing.Point(218, 82);
            this.ckb_szy1.Name = "ckb_szy1";
            this.ckb_szy1.Size = new System.Drawing.Size(72, 16);
            this.ckb_szy1.TabIndex = 4;
            this.ckb_szy1.Text = "暂未检测";
            this.ckb_szy1.UseVisualStyleBackColor = true;
            this.ckb_szy1.CheckedChanged += new System.EventHandler(this.ckb_szy1_CheckedChanged);
            // 
            // txt_szy1
            // 
            this.txt_szy1.Location = new System.Drawing.Point(89, 79);
            this.txt_szy1.Mask = "99999";
            this.txt_szy1.Name = "txt_szy1";
            this.txt_szy1.Size = new System.Drawing.Size(81, 21);
            this.txt_szy1.TabIndex = 3;
            this.txt_szy1.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "mmHg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "舒张压";
            // 
            // ckb_ssy1
            // 
            this.ckb_ssy1.AutoSize = true;
            this.ckb_ssy1.Location = new System.Drawing.Point(217, 37);
            this.ckb_ssy1.Name = "ckb_ssy1";
            this.ckb_ssy1.Size = new System.Drawing.Size(72, 16);
            this.ckb_ssy1.TabIndex = 2;
            this.ckb_ssy1.Text = "暂未检测";
            this.ckb_ssy1.UseVisualStyleBackColor = true;
            this.ckb_ssy1.CheckedChanged += new System.EventHandler(this.ckb_ssy1_CheckedChanged);
            // 
            // txt_ssy1
            // 
            this.txt_ssy1.Location = new System.Drawing.Point(89, 33);
            this.txt_ssy1.Mask = "99999";
            this.txt_ssy1.Name = "txt_ssy1";
            this.txt_ssy1.Size = new System.Drawing.Size(81, 21);
            this.txt_ssy1.TabIndex = 1;
            this.txt_ssy1.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "mmHg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "收缩压";
            // 
            // UserControl_NK2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl_NK2";
            this.Size = new System.Drawing.Size(353, 126);
            ((System.ComponentModel.ISupportInitialize)(this.studentexamDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.MaskedTextBox txt_ssy1;
        public System.Windows.Forms.MaskedTextBox txt_szy1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.CheckBox ckb_ssy1;
        public System.Windows.Forms.CheckBox ckb_szy1;
    }
}
