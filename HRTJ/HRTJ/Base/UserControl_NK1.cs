using System;

using Com.cn.HRWJDataSet;

namespace HRTJ.Base
{
    public partial class UserControl_NK1 : Control
    {
        public UserControl_NK1()
        {
            InitializeComponent();

            this.cbb_xz.OldWidth = this.cbb_xz.Width;
            this.cbb_xz.ShowTextBoxString = "其它";


            this.cbb_f.OldWidth = this.cbb_f.Width;
            this.cbb_f.ShowTextBoxString = "其它";
            
        }

        public override void Init(HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            string f=Convert.ToString(row[studentexamDB.fColumn.ColumnName])
                + Convert.ToString(row[studentexamDB.fbzColumn.ColumnName]);
            if (!string.IsNullOrEmpty(f))
            {
                this.cbb_f.Text = f;
            }
            string gp = Convert.ToString(row[studentexamDB.gpColumn.ColumnName]);
            if (!string.IsNullOrEmpty(gp))
            {
                this.cbb_gp.Text = gp;
            }

            string xz = Convert.ToString(row[studentexamDB.xzColumn.ColumnName])
                + Convert.ToString(row[studentexamDB.xzbzColumn.ColumnName]);
            if (!string.IsNullOrEmpty(xz))
            {
                this.cbb_xz.Text = xz;
            }
            base.Init(row);
        }

        public override void CollectData(ref HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            row.f = this.cbb_f.Text1;
            row.fbz = this.cbb_f.Textbz;
            row.gp = this.cbb_gp.Text;
            row.xz = this.cbb_xz.Text1;
            row.xzbz = this.cbb_xz.Textbz;
            bool isComplete = true;
            //if (this.ckB_f.Checked)
            //{
            //    isComplete = false;
            //}
            //if (this.ckb_gp.Checked)
            //{
            //    isComplete = false;
            //}
            //if (this.ckb_xz.Checked)
            //{
            //    isComplete = false;
            //}
            if (isComplete)
            {
                // 内科1_体检状态 0-未检 1-已检
                row.state_nk1 = 1;
                // 内科1_体检日期
                row.updatetime_nk1 = DateTime.Now.Date;
            }
            base.CollectData(ref row);
        }

        #region 事件
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ID = UserControl_TJXX._DataGridKey;
        }

        private void ckb_xz_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckb_xz.Checked)
            {
                this.cbb_xz.Text = string.Empty;
                this.cbb_xz.Enabled = false;
            }
            else
            {
                this.cbb_xz.Enabled = true;
            }
        }

        private void ckB_f_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckB_f.Checked)
            {
                this.cbb_f.Text = string.Empty;
                this.cbb_f.Enabled = false;
            }
            else
            {
                this.cbb_f.Enabled = true;
            }
        }

        private void ckb_gp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckb_gp.Checked)
            {
                this.cbb_gp.Text = string.Empty;
                this.cbb_gp.Enabled = false;
            }
            else
            {
                this.cbb_gp.Enabled = true;
            }
        }
        #endregion
    }
}
