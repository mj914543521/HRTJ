using System;

using Com.cn.HRWJDataSet;

namespace HRTJ.Base
{
    public partial class UserControl_WK2 : Control
    {
        public UserControl_WK2()
        {
            InitializeComponent();
        }

        public override void Init(HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            base.Init(row);
            this.txt_fhl.Text =Convert.ToString(row[studentexamDB.fhlColumn.ColumnName]);
        }

        public override void CollectData(ref HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            row.fhl = this.txt_fhl.Text.Trim();

            bool isComplete = true;
            //if (this.ckb_fhl.Checked)
            //{
            //    isComplete = false;
            //}
            if (isComplete)
            {
                // 外科2_体检状态 0-未检 1-已检
                row.state_wk2 = 1;
                // 外科2_体检日期
                row.updatetime_wk2 = DateTime.Now.Date;
            }
            base.CollectData(ref row);
        }
        #region 事件

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ID = UserControl_TJXX._DataGridKey;
        }

        private void ckb_fhl_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckb_fhl.Checked)
            {
                this.txt_fhl.Text = string.Empty;
                this.txt_fhl.Enabled = false;
            }
            else
            {
                this.txt_fhl.Enabled = true;
            }
        }
        #endregion
    }
}
