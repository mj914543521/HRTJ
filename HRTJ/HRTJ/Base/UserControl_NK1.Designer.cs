namespace HRTJ.Base
{
    partial class UserControl_NK1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_f = new HRTJ.Base.ComBox(this.components);
            this.cbb_xz = new HRTJ.Base.ComBox(this.components);
            this.ckb_gp = new System.Windows.Forms.CheckBox();
            this.cbb_gp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckB_f = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckb_xz = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentexamDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_f);
            this.groupBox1.Controls.Add(this.cbb_xz);
            this.groupBox1.Controls.Add(this.ckb_gp);
            this.groupBox1.Controls.Add(this.cbb_gp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ckB_f);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ckb_xz);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "体检信息--内科①";
            // 
            // cbb_f
            // 
            this.cbb_f.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_f.FormattingEnabled = true;
            this.cbb_f.Items.AddRange(new object[] {
            "未检查",
            "（—）",
            "肺部呼吸音增粗或增强",
            "支气管哮鸣音",
            "肺部啰音",
            "肺部呼吸音减低",
            "其它"});
            this.cbb_f.Location = new System.Drawing.Point(69, 74);
            this.cbb_f.Name = "cbb_f";
            this.cbb_f.OldWidth = 0;
            this.cbb_f.ShowTextBoxString = null;
            this.cbb_f.Size = new System.Drawing.Size(205, 20);
            this.cbb_f.TabIndex = 3;
            this.cbb_f.Text1 = "";
            this.cbb_f.Textbz = "";
            // 
            // cbb_xz
            // 
            this.cbb_xz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_xz.FormattingEnabled = true;
            this.cbb_xz.Items.AddRange(new object[] {
            "未检查",
            "正常",
            "先心病术后无杂音",
            "先心病术后有杂音",
            "心前区收缩期二级及以上杂音",
            "心前区舒张期杂音",
            "心律不齐",
            "早搏",
            "心动过速",
            "心动过缓",
            "其它"});
            this.cbb_xz.Location = new System.Drawing.Point(69, 36);
            this.cbb_xz.Name = "cbb_xz";
            this.cbb_xz.OldWidth = 0;
            this.cbb_xz.ShowTextBoxString = null;
            this.cbb_xz.Size = new System.Drawing.Size(205, 20);
            this.cbb_xz.TabIndex = 1;
            this.cbb_xz.Text1 = "";
            this.cbb_xz.Textbz = "";
            // 
            // ckb_gp
            // 
            this.ckb_gp.AutoSize = true;
            this.ckb_gp.Location = new System.Drawing.Point(290, 117);
            this.ckb_gp.Name = "ckb_gp";
            this.ckb_gp.Size = new System.Drawing.Size(72, 16);
            this.ckb_gp.TabIndex = 6;
            this.ckb_gp.Text = "暂未检测";
            this.ckb_gp.UseVisualStyleBackColor = true;
            this.ckb_gp.CheckedChanged += new System.EventHandler(this.ckb_gp_CheckedChanged);
            // 
            // cbb_gp
            // 
            this.cbb_gp.BackColor = System.Drawing.SystemColors.Window;
            this.cbb_gp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_gp.FormattingEnabled = true;
            this.cbb_gp.Items.AddRange(new object[] {
            "未检查",
            "肝脾未触及",
            "肝可触及(肋缘下1cm以上)",
            "脾可触及",
            "肝脾可触及"});
            this.cbb_gp.Location = new System.Drawing.Point(69, 114);
            this.cbb_gp.Name = "cbb_gp";
            this.cbb_gp.Size = new System.Drawing.Size(205, 20);
            this.cbb_gp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "肝脾";
            // 
            // ckB_f
            // 
            this.ckB_f.AutoSize = true;
            this.ckB_f.Location = new System.Drawing.Point(290, 78);
            this.ckB_f.Name = "ckB_f";
            this.ckB_f.Size = new System.Drawing.Size(72, 16);
            this.ckB_f.TabIndex = 4;
            this.ckB_f.Text = "暂未检测";
            this.ckB_f.UseVisualStyleBackColor = true;
            this.ckB_f.CheckedChanged += new System.EventHandler(this.ckB_f_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "  肺";
            // 
            // ckb_xz
            // 
            this.ckb_xz.AutoSize = true;
            this.ckb_xz.Location = new System.Drawing.Point(290, 38);
            this.ckb_xz.Name = "ckb_xz";
            this.ckb_xz.Size = new System.Drawing.Size(72, 16);
            this.ckb_xz.TabIndex = 2;
            this.ckb_xz.Text = "暂未检测";
            this.ckb_xz.UseVisualStyleBackColor = true;
            this.ckb_xz.CheckedChanged += new System.EventHandler(this.ckb_xz_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "心脏";
            // 
            // UserControl_NK1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl_NK1";
            this.Size = new System.Drawing.Size(396, 165);
            ((System.ComponentModel.ISupportInitialize)(this.studentexamDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckb_xz;
        private System.Windows.Forms.CheckBox ckB_f;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckb_gp;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbb_gp;
        private ComBox cbb_xz;
        private ComBox cbb_f;
    }
}
