using System;

using Com.cn.HRWJDataSet;

namespace HRTJ.Base
{
    public partial class UserControl_YK1 : Control
    {
        public UserControl_YK1()
        {
            InitializeComponent();
        }

        public override void Init(HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            this.txt_jzslleft.Text = Convert.ToString(row[studentexamDB.jzslleftColumn.ColumnName]);
            this.txt_jzslright.Text = Convert.ToString(row[studentexamDB.jzslrightColumn.ColumnName]);

            txt_lyslleft.Text = Convert.ToString(row[studentexamDB.lyslleftColumn.ColumnName]);
            txt_lyslright.Text = Convert.ToString(row[studentexamDB.lyslrightColumn.ColumnName]);
            base.Init(row);
        }
        public override void CollectData(ref HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            row.jzslleft=this.txt_jzslleft.Text.Trim();
            row.jzslright = this.txt_jzslright.Text.Trim();

            row.lyslleft = txt_lyslleft.Text.Trim();
            row.lyslright = txt_lyslright.Text.Trim();

            bool isComplete = true;
            //if (this.ckb_jzslleft.Checked)
            //{
            //    isComplete = false;
            //}
            //if (this.ckb_jzslright.Checked)
            //{
            //    isComplete = false;
            //}
            //if (this.ckb_lyslleft.Checked)
            //{
            //    isComplete = false;
            //}
            //if (this.ckb_lyslright.Checked)
            //{
            //    isComplete = false;
            //}
            if (isComplete)
            {
                // 眼科1_体检状态 0-未检 1-已检
                row.state_yk1 = 1;
                // 眼科1_体检日期
                row.updatetime_yk1 = DateTime.Now.Date;
            }
            base.CollectData(ref row);
        }

        #region 事件

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ID = UserControl_TJXX._DataGridKey;
        }

        private void ckb_lyslleft_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_lyslleft.Checked)
            {
                this.txt_lyslleft.Text = string.Empty;
                this.txt_lyslleft.Enabled = false;
            }
            else
            {
                this.txt_lyslleft.Enabled = true;
            }
        }

        private void ckb_lyslright_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_lyslright.Checked)
            {
                this.txt_lyslright.Text = string.Empty;
                this.txt_lyslright.Enabled = false;
            }
            else
            {
                this.txt_lyslright.Enabled = true;
            }
        }

        private void ckb_jzslleft_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_jzslleft.Checked)
            {
                this.txt_jzslleft.Text = string.Empty;
                this.txt_jzslleft.Enabled = false;
            }
            else
            {
                this.txt_jzslleft.Enabled = true;
            }
        }

        private void ckb_jzslright_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_jzslright.Checked)
            {
                this.txt_jzslright.Text = string.Empty;
                this.txt_jzslright.Enabled = false;
            }
            else
            {
                this.txt_jzslright.Enabled = true;
            }
        }
        #endregion

        private void txt_lyslleft_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
