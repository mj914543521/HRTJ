using System;
using Com.cn.HRWJDataSet;


namespace HRTJ.Base
{
    public partial class UserControl_YK2 : Control
    {
        public UserControl_YK2()
        {
            InitializeComponent();
        }

        public override void Init(HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            base.Init(row);
            string jmy = Convert.ToString(row[studentexamDB.jmyColumn.ColumnName]);
            if (!string.IsNullOrEmpty(jmy))
            {
                this.cbb_jmy.Text = jmy;
            }
            string sj = Convert.ToString(row[studentexamDB.sjColumn.ColumnName]);
            if (!string.IsNullOrEmpty(sj))
            {
                this.cbb_sj.Text = sj;
            }

            string sy = Convert.ToString(row[studentexamDB.syColumn.ColumnName]);
            if (!string.IsNullOrEmpty(sy))
            {
                this.cbb_sy.Text = sy;
            }
        }

        public override void CollectData(ref HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            row.jmy = this.cbb_jmy.Text;
            row.sj = this.cbb_sj.Text;
            row.sy = this.cbb_sy.Text;
            bool isComplete = true;
            //if (this.ckb_jmy.Checked)
            //{
            //    isComplete = false;
            //}
            //if (this.ckb_sj.Checked)
            //{
            //    isComplete = false;
            //}
            //if (this.ckb_sy.Checked)
            //{
            //    isComplete = false;
            //}
            if (isComplete)
            {
                // 眼科2_体检状态 0-未检 1-已检
                row.state_yk2 = 1;
                // 眼科2_体检日期
                row.updatetime_yk2 = DateTime.Now.Date;
            }
            base.CollectData(ref row);
        }
        #region 事件

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ID = UserControl_TJXX._DataGridKey;
        }
        private void ckb_sy_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_sy.Checked)
            {
                this.cbb_sy.Text = string.Empty;
                this.cbb_sy.Enabled = false;
            }
            else
            {
                this.cbb_sy.Enabled = true;
            }
        }

        private void ckb_sj_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_sj.Checked)
            {
                this.cbb_sj.Text = string.Empty;
                this.cbb_sj.Enabled = false;
            }
            else
            {
                this.cbb_sj.Enabled = true;
            }
        }

        private void ckb_jmy_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_jmy.Checked)
            {
                this.cbb_jmy.Text = string.Empty;
                this.cbb_jmy.Enabled = false;
            }
            else
            {
                this.cbb_jmy.Enabled = true;
            }
        }
        #endregion
    }
}
