using System;

using Com.cn.HRWJDataSet;
namespace HRTJ.Base
{
    public partial class UserControl_NK2 : Control
    {
        public UserControl_NK2()
        {
            InitializeComponent();
        }
        public override void Init(HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            this.txt_ssy1.Text = Convert.ToString(row[studentexamDB.ssyColumn.ColumnName]);
            this.txt_szy1.Text = Convert.ToString(row[studentexamDB.szyColumn.ColumnName]);
            base.Init(row);
        }

        public override void CollectData(ref HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            row.ssy = this.txt_ssy1.Text.Trim();
            row.szy = this.txt_szy1.Text.Trim();

            bool isComplete = true;
            //if (this.ckb_ssy1.Checked)
            //{
            //    isComplete = false;
            //}
            //if (this.ckb_szy1.Checked)
            //{
            //    isComplete = false;
            //}
            if (isComplete)
            {
                // 内科2_体检状态 0-未检 1-已检
                row.state_nk2 = 1;
                // 内科2_体检日期
                row.updatetime_nk2 = DateTime.Now.Date;
            }

            base.CollectData(ref row);
        }
        #region 事件
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ID = UserControl_TJXX._DataGridKey;
        }
        
        private void ckb_ssy1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_ssy1.Checked)
            {
                this.txt_ssy1.Text = string.Empty;
                this.txt_ssy1.Enabled = false;
            }
            else
            {
                this.txt_ssy1.Enabled = true;
            }
        }

        

        private void ckb_szy1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_szy1.Checked)
            {
                this.txt_szy1.Text = string.Empty;
                this.txt_szy1.Enabled = false;
            }
            else
            {
                this.txt_szy1.Enabled = true;
            }
        }

        
        #endregion



    }
}
