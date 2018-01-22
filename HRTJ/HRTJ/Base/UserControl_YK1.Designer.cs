namespace HRTJ.Base
{
    partial class UserControl_YK1
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckb_jzslright = new System.Windows.Forms.CheckBox();
            this.txt_jzslright = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckb_jzslleft = new System.Windows.Forms.CheckBox();
            this.txt_jzslleft = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckb_lyslright = new System.Windows.Forms.CheckBox();
            this.txt_lyslright = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckb_lyslleft = new System.Windows.Forms.CheckBox();
            this.txt_lyslleft = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentexamDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "体检信息--眼科①";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckb_jzslright);
            this.groupBox3.Controls.Add(this.txt_jzslright);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.ckb_jzslleft);
            this.groupBox3.Controls.Add(this.txt_jzslleft);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(612, 48);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "矫正视力";
            // 
            // ckb_jzslright
            // 
            this.ckb_jzslright.AutoSize = true;
            this.ckb_jzslright.Location = new System.Drawing.Point(469, 17);
            this.ckb_jzslright.Name = "ckb_jzslright";
            this.ckb_jzslright.Size = new System.Drawing.Size(72, 16);
            this.ckb_jzslright.TabIndex = 8;
            this.ckb_jzslright.Text = "暂未检测";
            this.ckb_jzslright.UseVisualStyleBackColor = true;
            this.ckb_jzslright.CheckedChanged += new System.EventHandler(this.ckb_jzslright_CheckedChanged);
            // 
            // txt_jzslright
            // 
            this.txt_jzslright.Location = new System.Drawing.Point(354, 15);
            this.txt_jzslright.Mask = "9.99";
            this.txt_jzslright.Name = "txt_jzslright";
            this.txt_jzslright.Size = new System.Drawing.Size(100, 21);
            this.txt_jzslright.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "右";
            // 
            // ckb_jzslleft
            // 
            this.ckb_jzslleft.AutoSize = true;
            this.ckb_jzslleft.Location = new System.Drawing.Point(190, 20);
            this.ckb_jzslleft.Name = "ckb_jzslleft";
            this.ckb_jzslleft.Size = new System.Drawing.Size(72, 16);
            this.ckb_jzslleft.TabIndex = 6;
            this.ckb_jzslleft.Text = "暂未检测";
            this.ckb_jzslleft.UseVisualStyleBackColor = true;
            this.ckb_jzslleft.CheckedChanged += new System.EventHandler(this.ckb_jzslleft_CheckedChanged);
            // 
            // txt_jzslleft
            // 
            this.txt_jzslleft.Location = new System.Drawing.Point(75, 18);
            this.txt_jzslleft.Mask = "9.99";
            this.txt_jzslleft.Name = "txt_jzslleft";
            this.txt_jzslleft.Size = new System.Drawing.Size(100, 21);
            this.txt_jzslleft.TabIndex = 5;
            this.txt_jzslleft.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "左";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckb_lyslright);
            this.groupBox2.Controls.Add(this.txt_lyslright);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ckb_lyslleft);
            this.groupBox2.Controls.Add(this.txt_lyslleft);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 56);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "裸眼视力";
            // 
            // ckb_lyslright
            // 
            this.ckb_lyslright.AutoSize = true;
            this.ckb_lyslright.Location = new System.Drawing.Point(467, 22);
            this.ckb_lyslright.Name = "ckb_lyslright";
            this.ckb_lyslright.Size = new System.Drawing.Size(72, 16);
            this.ckb_lyslright.TabIndex = 4;
            this.ckb_lyslright.Text = "暂未检测";
            this.ckb_lyslright.UseVisualStyleBackColor = true;
            this.ckb_lyslright.CheckedChanged += new System.EventHandler(this.ckb_lyslright_CheckedChanged);
            // 
            // txt_lyslright
            // 
            this.txt_lyslright.Location = new System.Drawing.Point(352, 20);
            this.txt_lyslright.Mask = "9.99";
            this.txt_lyslright.Name = "txt_lyslright";
            this.txt_lyslright.Size = new System.Drawing.Size(100, 21);
            this.txt_lyslright.TabIndex = 3;
            this.txt_lyslright.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "右";
            // 
            // ckb_lyslleft
            // 
            this.ckb_lyslleft.AutoSize = true;
            this.ckb_lyslleft.Location = new System.Drawing.Point(190, 22);
            this.ckb_lyslleft.Name = "ckb_lyslleft";
            this.ckb_lyslleft.Size = new System.Drawing.Size(72, 16);
            this.ckb_lyslleft.TabIndex = 2;
            this.ckb_lyslleft.Text = "暂未检测";
            this.ckb_lyslleft.UseVisualStyleBackColor = true;
            this.ckb_lyslleft.CheckedChanged += new System.EventHandler(this.ckb_lyslleft_CheckedChanged);
            // 
            // txt_lyslleft
            // 
            this.txt_lyslleft.Location = new System.Drawing.Point(75, 20);
            this.txt_lyslleft.Mask = "9.99";
            this.txt_lyslleft.Name = "txt_lyslleft";
            this.txt_lyslleft.Size = new System.Drawing.Size(100, 21);
            this.txt_lyslleft.TabIndex = 1;
            this.txt_lyslleft.TextChanged += new System.EventHandler(this.txt_lyslleft_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "左";
            // 
            // UserControl_YK1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl_YK1";
            this.Size = new System.Drawing.Size(618, 122);
            ((System.ComponentModel.ISupportInitialize)(this.studentexamDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_lyslleft;
        private System.Windows.Forms.CheckBox ckb_lyslleft;
        private System.Windows.Forms.CheckBox ckb_lyslright;
        private System.Windows.Forms.MaskedTextBox txt_lyslright;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckb_jzslright;
        private System.Windows.Forms.MaskedTextBox txt_jzslright;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckb_jzslleft;
        private System.Windows.Forms.MaskedTextBox txt_jzslleft;
        private System.Windows.Forms.Label label4;
    }
}
