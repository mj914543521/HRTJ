using System;
using Com.cn.HRWJDataSet;


namespace HRTJ.Base
{
    public partial class UserControl_JYK : Control
    {
        public UserControl_JYK()
        {
            InitializeComponent();
        }

        public override void Init(HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            if (row ==null)
            {
                return;
            }
            this.txt_xss.Text =Convert.ToString(row[studentexamDB.xssColumn.ColumnName]);
        }

        public override void CollectData(ref HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            row.xss = this.txt_xss.Text.Trim();
            bool isComplete = true;
            //if (this.checkBox1.Checked)
            //{
            //    isComplete = false;
            //}
            if (isComplete)
            {
                // 检验科_体检状态 0-未检 1-已检
                row.state_jyk = 1;
                // 检验科_体检日期
                row.updatetime_jyk = DateTime.Now.Date;
            }
            base.CollectData(ref row);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.txt_xss.Text = string.Empty;
                this.txt_xss.Enabled = false;
            }
            else
            {
                this.txt_xss.Enabled = true;
            }
        }

        private void UserControl_JYK_Load(object sender, EventArgs e)
        {
            this.ID = UserControl_TJXX._DataGridKey;
        }


       
    }
}
