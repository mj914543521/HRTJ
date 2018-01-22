namespace HRTJ.Base
{
    partial class UserControl_YK2
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
            this.ckb_jmy = new System.Windows.Forms.CheckBox();
            this.cbb_jmy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckb_sj = new System.Windows.Forms.CheckBox();
            this.cbb_sj = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckb_sy = new System.Windows.Forms.CheckBox();
            this.cbb_sy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentexamDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckb_jmy);
            this.groupBox1.Controls.Add(this.cbb_jmy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ckb_sj);
            this.groupBox1.Controls.Add(this.cbb_sj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ckb_sy);
            this.groupBox1.Controls.Add(this.cbb_sy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "体检信息--眼科②";
            // 
            // ckb_jmy
            // 
            this.ckb_jmy.AutoSize = true;
            this.ckb_jmy.Location = new System.Drawing.Point(281, 114);
            this.ckb_jmy.Name = "ckb_jmy";
            this.ckb_jmy.Size = new System.Drawing.Size(72, 16);
            this.ckb_jmy.TabIndex = 21;
            this.ckb_jmy.Text = "暂未检测";
            this.ckb_jmy.UseVisualStyleBackColor = true;
            this.ckb_jmy.CheckedChanged += new System.EventHandler(this.ckb_jmy_CheckedChanged);
            // 
            // cbb_jmy
            // 
            this.cbb_jmy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_jmy.FormattingEnabled = true;
            this.cbb_jmy.Items.AddRange(new object[] {
            "未检查",
            "无",
            "沙眼性炎症-滤泡（TF）",
            "沙眼性炎症-剧烈的（TI）",
            "沙眼性疤痕（TS）",
            "沙眼性倒睫（TT）",
            "角膜混浊（CO）"});
            this.cbb_jmy.Location = new System.Drawing.Point(89, 112);
            this.cbb_jmy.Name = "cbb_jmy";
            this.cbb_jmy.Size = new System.Drawing.Size(170, 20);
            this.cbb_jmy.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "结膜炎";
            // 
            // ckb_sj
            // 
            this.ckb_sj.AutoSize = true;
            this.ckb_sj.Location = new System.Drawing.Point(281, 73);
            this.ckb_sj.Name = "ckb_sj";
            this.ckb_sj.Size = new System.Drawing.Size(72, 16);
            this.ckb_sj.TabIndex = 18;
            this.ckb_sj.Text = "暂未检测";
            this.ckb_sj.UseVisualStyleBackColor = true;
            this.ckb_sj.CheckedChanged += new System.EventHandler(this.ckb_sj_CheckedChanged);
            // 
            // cbb_sj
            // 
            this.cbb_sj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_sj.FormattingEnabled = true;
            this.cbb_sj.Items.AddRange(new object[] {
            "未检查",
            "正常",
            "色弱",
            "色盲"});
            this.cbb_sj.Location = new System.Drawing.Point(89, 71);
            this.cbb_sj.Name = "cbb_sj";
            this.cbb_sj.Size = new System.Drawing.Size(170, 20);
            this.cbb_sj.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "色觉";
            // 
            // ckb_sy
            // 
            this.ckb_sy.AutoSize = true;
            this.ckb_sy.Location = new System.Drawing.Point(281, 31);
            this.ckb_sy.Name = "ckb_sy";
            this.ckb_sy.Size = new System.Drawing.Size(72, 16);
            this.ckb_sy.TabIndex = 15;
            this.ckb_sy.Text = "暂未检测";
            this.ckb_sy.UseVisualStyleBackColor = true;
            this.ckb_sy.CheckedChanged += new System.EventHandler(this.ckb_sy_CheckedChanged);
            // 
            // cbb_sy
            // 
            this.cbb_sy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_sy.FormattingEnabled = true;
            this.cbb_sy.Items.AddRange(new object[] {
            "未检查",
            "无",
            "沙眼性炎症-滤泡（TF）",
            "沙眼性炎症-剧烈的（TI）",
            "沙眼性疤痕（TS）",
            "沙眼性倒睫（TT）",
            "角膜混浊（CO）"});
            this.cbb_sy.Location = new System.Drawing.Point(89, 29);
            this.cbb_sy.Name = "cbb_sy";
            this.cbb_sy.Size = new System.Drawing.Size(170, 20);
            this.cbb_sy.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "沙眼";
            // 
            // UserControl_YK2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl_YK2";
            this.Size = new System.Drawing.Size(442, 160);
            ((System.ComponentModel.ISupportInitialize)(this.studentexamDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_sy;
        private System.Windows.Forms.CheckBox ckb_sy;
        private System.Windows.Forms.CheckBox ckb_sj;
        private System.Windows.Forms.ComboBox cbb_sj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckb_jmy;
        private System.Windows.Forms.ComboBox cbb_jmy;
        private System.Windows.Forms.Label label3;
    }
}
