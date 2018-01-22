using System;

using Com.cn.HRWJDataSet;

namespace HRTJ.Base
{
    public partial class UserControl_WK1 : Control
    {
        public UserControl_WK1()
        {
            InitializeComponent();

            #region 自定义控件
            this.cbb_jz.OldWidth = this.cbb_jz.Width;
            this.cbb_jz.ShowTextBoxString = "其它";

            this.cbb_pf.OldWidth = this.cbb_jz.Width;
            this.cbb_pf.ShowTextBoxString = "其它";

            this.cbb_szgj.OldWidth = this.cbb_jz.Width;
            this.cbb_szgj.ShowTextBoxString = "其它";

            this.cbb_tj.OldWidth = this.cbb_jz.Width;
            this.cbb_tj.ShowTextBoxString = "其它";

            this.cbb_xb.OldWidth = this.cbb_jz.Width;
            this.cbb_xb.ShowTextBoxString = "其它";
            #endregion
        }
        public override void Init(HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            // 身高
            string sg=Convert.ToString(row[studentexamDB.sgColumn.ColumnName]);
            if (!string.IsNullOrEmpty(sg))
            {
                this.txt_sg.Text = sg;    
            }
            
            // 体重
            string tz = Convert.ToString(row[studentexamDB.tzColumn.ColumnName]);
            if (!string.IsNullOrEmpty(tz))
            {
                this.txt_tz.Text = tz;
            }
            // 头颈
            string tj = Convert.ToString(row[studentexamDB.tjColumn.ColumnName])
                + Convert.ToString(row[studentexamDB.tjbzColumn.ColumnName]);
            if (!string.IsNullOrEmpty(tj))
            {
                this.cbb_tj.Text = tj;
            }
            // 脊柱
            string jz = Convert.ToString(row[studentexamDB.jzColumn.ColumnName])
                + Convert.ToString(row[studentexamDB.jzbzColumn.ColumnName]);
            if (!string.IsNullOrEmpty(jz))
            {
                this.cbb_jz.Text = jz;
            }
            // 皮肤
            string pf = Convert.ToString(row[studentexamDB.pfColumn.ColumnName])
                + Convert.ToString(row[studentexamDB.pfbzColumn.ColumnName]);
            if (!string.IsNullOrEmpty(pf))
            {
                this.cbb_pf.Text = pf;
            }
            // 胸部
            string xb = Convert.ToString(row[studentexamDB.xbColumn.ColumnName])
                + Convert.ToString(row[studentexamDB.xbbzColumn.ColumnName]);
            if (!string.IsNullOrEmpty(xb))
            {
                this.cbb_xb.Text = xb;
            }
            // 四肢关节
            string szgj = Convert.ToString(row[studentexamDB.szgjColumn.ColumnName])
                + Convert.ToString(row[studentexamDB.szgjbzColumn.ColumnName]);
            if (!string.IsNullOrEmpty(szgj))
            {
                this.cbb_szgj.Text = szgj;
            }
            base.Init(row);
        }

        public override void CollectData(ref HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            // 身高
            row.sg=this.txt_sg.Text.Trim();
            // 体重
            row.tz=this.txt_tz.Text.Trim();
            // 头颈
            row.tj=this.cbb_tj.Text1.Trim();
            row.tjbz = this.cbb_tj.Textbz.Trim();
            // 脊柱
            row.jz=this.cbb_jz.Text1.Trim();
            row.jzbz = this.cbb_jz.Textbz.Trim();
            // 皮肤
            row.pf=this.cbb_pf.Text1.Trim();
            row.pfbz = this.cbb_pf.Textbz.Trim();
            // 胸部
            row.xb=this.cbb_xb.Text1.Trim();
            row.xbbz = this.cbb_xb.Textbz.Trim();
            // 四肢关节
            row.szgj=this.cbb_szgj.Text1.Trim();
            row.szgjbz = this.cbb_szgj.Textbz.Trim();

            bool isComplete = true;
            //// 身高
            //if (this.ckb_sg.Checked)
            //{
            //    isComplete = false;
            //}
            //// 体重
            //if (this.ckb_tz.Checked)
            //{
            //    isComplete = false;
            //}

            //// 头颈
            //if (this.ckb_tj.Checked)
            //{
            //    isComplete = false;
            //}

            //// 脊柱
            //if (this.ckb_jz.Checked)
            //{
            //    isComplete = false;
            //}

            //// 皮肤
            //if (this.ckb_pf.Checked)
            //{
            //    isComplete = false;
            //}

            //// 胸部
            //if (this.ckb_xb.Checked)
            //{
            //    isComplete = false;
            //}

            //// 四肢关节
            //if (this.ckb_szgj.Checked)
            //{
            //    isComplete = false;
            //}
            if (isComplete)
            {
                // 外科1_体检状态 0-未检 1-已检
                row.state_wk1 = 1;
                // 外科1_体检日期
                row.updatetime_wk1 = DateTime.Now.Date;
            }
            base.CollectData(ref row);
        }

        #region 事件

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ID = UserControl_TJXX._DataGridKey;
        }

        private void ckb_sg_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_sg.Checked)
            {
                txt_sg.Text = string.Empty;
                txt_sg.Enabled = false;
            }
            else
            {
                txt_sg.Enabled = true;
            }
        }

        private void ckb_tz_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_tz.Checked)
            {
                txt_tz.Text = string.Empty;
                txt_tz.Enabled = false;
            }
            else
            {
                txt_tz.Enabled = true;
            }
        }

        private void ckb_tj_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_tj.Checked)
            {
                this.cbb_tj.Text = string.Empty;
                this.cbb_tj.Enabled = false;
            }
            else
            {
                this.cbb_tj.Enabled = true;
            }
        }

        private void ckb_jz_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_jz.Checked)
            {
                this.cbb_jz.Text = string.Empty;
                this.cbb_jz.Enabled = false;
            }
            else
            {
                this.cbb_jz.Enabled = true;
            }
        }

        private void ckb_pf_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_pf.Checked)
            {
                this.cbb_pf.Text = string.Empty;
                this.cbb_pf.Enabled = false;
            }
            else
            {
                this.cbb_pf.Enabled = true;
            }
        }

        private void ckb_xb_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_xb.Checked)
            {
                this.cbb_xb.Text = string.Empty;
                this.cbb_xb.Enabled = false;
            }
            else
            {
                this.cbb_xb.Enabled = true;
            }
        }

        private void ckb_szgj_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_szgj.Checked)
            {
                this.cbb_szgj.Text = string.Empty;
                this.cbb_szgj.Enabled = false;
            }
            else
            {
                this.cbb_szgj.Enabled = true;
            }
        }
        #endregion


    }
}
