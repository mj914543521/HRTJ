using System;

using System.Windows.Forms;
using Com.cn.HRWJDataSet;

namespace HRTJ.Base
{
    public partial class UserControl_KQK : Control
    {
        public UserControl_KQK()
        {
            InitializeComponent();
            bindQCComBox();
        }

        private void UserControl_KQK_Load(object sender, EventArgs e)
        {
            this.ID = UserControl_TJXX._DataGridKey;
        }

        public override void Init(HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            HRWJAccessDataSet.tb_studentexam_ClientDataTable table = new HRWJAccessDataSet.tb_studentexam_ClientDataTable();

            #region 龋齿情况
            #region 龋齿左上
            this.SetControlValue(cbb_qcl7top_1, null,
                Convert.ToString(row[table.qcl7topColumn.ColumnName]));

            this.SetControlValue(cbb_qcl6top_1, null,
                Convert.ToString(row[table.qcl6topColumn.ColumnName]));

            this.SetControlValue(cbb_qcl5top_1, cbb_qcl5top,
                Convert.ToString(row[table.qcl5topColumn.ColumnName]));

            this.SetControlValue(cbb_qcl4top_1, cbb_qcl4top,
                Convert.ToString(row[table.qcl4topColumn.ColumnName]));

            this.SetControlValue(cbb_qcl3top_1, cbb_qcl3top,
                Convert.ToString(row[table.qcl3topColumn.ColumnName]));

            this.SetControlValue(cbb_qcl2top_1, cbb_qcl2top,
                Convert.ToString(row[table.qcl2topColumn.ColumnName]));

            this.SetControlValue(cbb_qcl1top_1, cbb_qcl1top,
                Convert.ToString(row[table.qcl1topColumn.ColumnName]));
            #endregion

            #region 龋齿右上
            this.SetControlValue(cbb_qcr7top_1, null,
                Convert.ToString(row[table.qcr7topColumn.ColumnName]));

            this.SetControlValue(cbb_qcr6top_1, null,
                Convert.ToString(row[table.qcr6topColumn.ColumnName]));

            this.SetControlValue(cbb_qcr5top_1, cbb_qcr5top,
                Convert.ToString(row[table.qcr5topColumn.ColumnName]));

            this.SetControlValue(cbb_qcr4top_1, cbb_qcr4top,
                Convert.ToString(row[table.qcr4topColumn.ColumnName]));

            this.SetControlValue(cbb_qcr3top_1, cbb_qcr3top,
                Convert.ToString(row[table.qcr3topColumn.ColumnName]));

            this.SetControlValue(cbb_qcr2top_1, cbb_qcr2top,
                Convert.ToString(row[table.qcr2topColumn.ColumnName]));

            this.SetControlValue(cbb_qcr1top_1, cbb_qcr1top,
                Convert.ToString(row[table.qcr1topColumn.ColumnName]));
            #endregion

            #region 龋齿左下
            this.SetControlValue(cbb_qcl7bottom_1, null,
                Convert.ToString(row[table.qcl7bottomColumn.ColumnName]));

            this.SetControlValue(cbb_qcl6bottom_1, null,
                Convert.ToString(row[table.qcl6bottomColumn.ColumnName]));

            this.SetControlValue(cbb_qcl5bottom_1, cbb_qcl5bottom,
                Convert.ToString(row[table.qcl5bottomColumn.ColumnName]));

            this.SetControlValue(cbb_qcl4bottom_1, cbb_qcl4bottom,
                Convert.ToString(row[table.qcl4bottomColumn.ColumnName]));

            this.SetControlValue(cbb_qcl3bottom_1, cbb_qcl3bottom,
                Convert.ToString(row[table.qcl3bottomColumn.ColumnName]));

            this.SetControlValue(cbb_qcl2bottom_1, cbb_qcl2bottom,
                Convert.ToString(row[table.qcl2bottomColumn.ColumnName]));

            this.SetControlValue(cbb_qcl1bottom_1, cbb_qcl1bottom,
                Convert.ToString(row[table.qcl1bottomColumn.ColumnName]));
            #endregion

            #region 龋齿右下
            this.SetControlValue(cbb_qcr7bottom_1, null,
                Convert.ToString(row[table.qcr7bottomColumn.ColumnName]));

            this.SetControlValue(cbb_qcr6bottom_1, null,
                Convert.ToString(row[table.qcr6bottomColumn.ColumnName]));

            this.SetControlValue(cbb_qcr5bottom_1, cbb_qcr5bottom,
                Convert.ToString(row[table.qcr5bottomColumn.ColumnName]));

            this.SetControlValue(cbb_qcr4bottom_1, cbb_qcr4bottom,
                Convert.ToString(row[table.qcr4bottomColumn.ColumnName]));

            this.SetControlValue(cbb_qcr3bottom_1, cbb_qcr3bottom,
                Convert.ToString(row[table.qcr3bottomColumn.ColumnName]));

            this.SetControlValue(cbb_qcr2bottom_1, cbb_qcr2bottom,
                Convert.ToString(row[table.qcr2bottomColumn.ColumnName]));

            this.SetControlValue(cbb_qcr1bottom_1, cbb_qcr1bottom,
                Convert.ToString(row[table.qcr1bottomColumn.ColumnName]));
            #endregion
            #endregion

            #region 牙龈情况
            this.cbb_yyltop.Text = Convert.ToString(row[table.yyltopColumn.ColumnName]);
            this.cbb_yyctop.Text = Convert.ToString(row[table.yyctopColumn.ColumnName]);
            this.cbb_yyrtop.Text = Convert.ToString(row[table.yyrtopColumn.ColumnName]);

            this.cbb_yylbottom.Text = Convert.ToString(row[table.yylbottomColumn.ColumnName]);
            this.cbb_yycbottom.Text = Convert.ToString(row[table.yycbottomColumn.ColumnName]);
            this.cbb_yyrbottom.Text = Convert.ToString(row[table.yyrbottomColumn.ColumnName]);
            #endregion
            base.Init(row);
        }
        public override void CollectData(ref HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            HRWJAccessDataSet.tb_studentexam_ClientDataTable table = new HRWJAccessDataSet.tb_studentexam_ClientDataTable();
            #region 龋齿情况
            #region 龋齿左上
            this.SetRowValue(cbb_qcl7top_1, null, ref row,
                table.qcl7topColumn.ColumnName);

            this.SetRowValue(cbb_qcl6top_1, null, ref row,
                table.qcl6topColumn.ColumnName);

            this.SetRowValue(cbb_qcl5top_1, cbb_qcl5top, ref row,
                table.qcl5topColumn.ColumnName);

            this.SetRowValue(cbb_qcl4top_1, cbb_qcl4top, ref row,
                table.qcl4topColumn.ColumnName);

            this.SetRowValue(cbb_qcl3top_1, cbb_qcl3top, ref row,
                table.qcl3topColumn.ColumnName);

            this.SetRowValue(cbb_qcl2top_1, cbb_qcl2top, ref row,
                table.qcl2topColumn.ColumnName);

            this.SetRowValue(cbb_qcl1top_1, cbb_qcl1top, ref row,
                table.qcl1topColumn.ColumnName);
            #endregion

            #region 龋齿右上
            this.SetRowValue(cbb_qcr7top_1, null, ref row,
                table.qcr7topColumn.ColumnName);

            this.SetRowValue(cbb_qcr6top_1, null, ref row,
                table.qcr6topColumn.ColumnName);

            this.SetRowValue(cbb_qcr5top_1, cbb_qcr5top, ref row,
                table.qcr5topColumn.ColumnName);

            this.SetRowValue(cbb_qcr4top_1, cbb_qcr4top, ref row,
                table.qcr4topColumn.ColumnName);

            this.SetRowValue(cbb_qcr3top_1, cbb_qcr3top, ref row,
                table.qcr3topColumn.ColumnName);

            this.SetRowValue(cbb_qcr2top_1, cbb_qcr2top, ref row,
                table.qcr2topColumn.ColumnName);

            this.SetRowValue(cbb_qcr1top_1, cbb_qcr1top, ref row,
                table.qcr1topColumn.ColumnName);
            #endregion

            #region 龋齿左下
            this.SetRowValue(cbb_qcl7bottom_1, null, ref row,
                table.qcl7bottomColumn.ColumnName);

            this.SetRowValue(cbb_qcl6bottom_1, null, ref row,
                table.qcl6bottomColumn.ColumnName);

            this.SetRowValue(cbb_qcl5bottom_1, cbb_qcl5bottom, ref row,
                table.qcl5bottomColumn.ColumnName);

            this.SetRowValue(cbb_qcl4bottom_1, cbb_qcl4bottom, ref row,
                table.qcl4bottomColumn.ColumnName);

            this.SetRowValue(cbb_qcl3bottom_1, cbb_qcl3bottom, ref row,
                table.qcl3bottomColumn.ColumnName);

            this.SetRowValue(cbb_qcl2bottom_1, cbb_qcl2bottom, ref row,
                table.qcl2bottomColumn.ColumnName);

            this.SetRowValue(cbb_qcl1bottom_1, cbb_qcl1bottom, ref row,
                table.qcl1bottomColumn.ColumnName);
            #endregion

            #region 龋齿右下
            this.SetRowValue(cbb_qcr7bottom_1, null, ref row,
                table.qcr7bottomColumn.ColumnName);

            this.SetRowValue(cbb_qcr6bottom_1, null, ref row,
                table.qcr6bottomColumn.ColumnName);

            this.SetRowValue(cbb_qcr5bottom_1, cbb_qcr5bottom, ref row,
                table.qcr5bottomColumn.ColumnName);

            this.SetRowValue(cbb_qcr4bottom_1, cbb_qcr4bottom, ref row,
                table.qcr4bottomColumn.ColumnName);

            this.SetRowValue(cbb_qcr3bottom_1, cbb_qcr3bottom, ref row,
                table.qcr3bottomColumn.ColumnName);

            this.SetRowValue(cbb_qcr2bottom_1, cbb_qcr2bottom, ref row,
                table.qcr2bottomColumn.ColumnName);

            this.SetRowValue(cbb_qcr1bottom_1, cbb_qcr1bottom, ref row,
                table.qcr1bottomColumn.ColumnName);
            #endregion
            #endregion

            #region 牙龈情况
            row[table.yyltopColumn.ColumnName] = this.cbb_yyltop.Text.Trim();
            row[table.yyctopColumn.ColumnName] = this.cbb_yyctop.Text.Trim();
            row[table.yyrtopColumn.ColumnName] = this.cbb_yyrtop.Text.Trim();

            row[table.yylbottomColumn.ColumnName] = this.cbb_yylbottom.Text.Trim();
            row[table.yycbottomColumn.ColumnName] = this.cbb_yycbottom.Text.Trim();
            row[table.yyrbottomColumn.ColumnName] = this.cbb_yyrbottom.Text.Trim();
            #endregion

            

            bool isComplete = true;
            //if (this.checkBox1.Checked)
            //{
            //    isComplete = false;
            //}
            if (isComplete)
            {
                // 口腔科_体检状态 0-未检 1-已检
                row.state_kqk = 1;
                // 口腔科_体检日期
                row.updatetime_kqk = DateTime.Now.Date;
            }
            base.CollectData(ref row);
        }

        #region 龋齿相关方法
        private void SetRowValue(ComboBox cbb_1, ComboBox cbb, ref HRWJAccessDataSet.tb_studentexam_ClientRow row, string colName)
        {
            string value = string.Empty;
            if (null != cbb_1)
            {
                value = cbb_1.Text;
            }
            if (null != cbb)
            {
                value = value + "," + cbb.Text;
            }
            row[colName] = value;
        }

        private void SetControlValue(ComboBox cbb_1, ComboBox cbb, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return;
            }
            if (!value.Contains(","))
            {
                if (cbb_1 != null)
                {
                    cbb_1.Text = value;
                }
            }
            else
            {
                string[] strs = value.Split(',');
                if (cbb!=null)
                {
                    cbb.Text = strs[1];    
                }
                if (cbb_1 != null)
                {
                    cbb_1.Text = strs[0];
                }
            }
        }

        private void bindQCComBox()
        {
            #region
            this.BindCombox(cbb_qcl7top_1);

            this.BindCombox(cbb_qcl6top_1);

            this.BindCombox(cbb_qcl5top_1);
            this.BindCombox(cbb_qcl5top);

            this.BindCombox(cbb_qcl4top_1);
            this.BindCombox(cbb_qcl4top);

            this.BindCombox(cbb_qcl3top_1);
            this.BindCombox(cbb_qcl3top);

            this.BindCombox(cbb_qcl2top_1);
            this.BindCombox(cbb_qcl2top);


            this.BindCombox(cbb_qcl1top_1);
            this.BindCombox(cbb_qcl1top);
            #endregion

            #region 龋齿右上
            this.BindCombox(cbb_qcr7top_1);

            this.BindCombox(cbb_qcr6top_1);

            this.BindCombox(cbb_qcr5top_1);
            this.BindCombox(cbb_qcr5top);

            this.BindCombox(cbb_qcr4top_1);
            this.BindCombox(cbb_qcr4top);
            this.BindCombox(cbb_qcr3top_1);
            this.BindCombox(cbb_qcr3top);

            this.BindCombox(cbb_qcr2top_1);
            this.BindCombox(cbb_qcr2top);

            this.BindCombox(cbb_qcr1top_1);
            this.BindCombox(cbb_qcr1top);
            #endregion

            #region 龋齿左下
            this.BindCombox(cbb_qcl7bottom_1);

            this.BindCombox(cbb_qcl6bottom_1);

            this.BindCombox(cbb_qcl5bottom_1);
            this.BindCombox(cbb_qcl5bottom);

            this.BindCombox(cbb_qcl4bottom_1);
            this.BindCombox(cbb_qcl4bottom);

            this.BindCombox(cbb_qcl3bottom_1);
            this.BindCombox(cbb_qcl3bottom);

            this.BindCombox(cbb_qcl2bottom_1);
            this.BindCombox(cbb_qcl2bottom);

            this.BindCombox(cbb_qcl1bottom_1);
            this.BindCombox(cbb_qcl1bottom);
            #endregion

            #region 龋齿右下
            this.BindCombox(cbb_qcr7bottom_1);

            this.BindCombox(cbb_qcr6bottom_1);

            this.BindCombox(cbb_qcr5bottom_1);
            this.BindCombox(cbb_qcr5bottom);

            this.BindCombox(cbb_qcr4bottom_1);
            this.BindCombox(cbb_qcr4bottom);

            this.BindCombox(cbb_qcr3bottom_1);
            this.BindCombox(cbb_qcr3bottom);

            this.BindCombox(cbb_qcr2bottom_1);
            this.BindCombox(cbb_qcr2bottom);

            this.BindCombox(cbb_qcr1bottom_1);
            this.BindCombox(cbb_qcr1bottom);
            #endregion
        }
        private void BindCombox(ComboBox box)
        {
            box.Items.Add("00");
            box.Items.Add("01");
            box.Items.Add("02");
            box.Items.Add("03");
            box.Items.Add("04");
            box.Items.Add("05");
            box.Items.Add("06");
            box.Items.Add("09");
            box.Items.Add("30");
            box.Items.Add("31");
            box.Items.Add("99");
            box.Items.Add(" ");
        }

        #region 龋齿暂未检测 逻辑
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool isEnable = true;
            if (checkBox1.Checked)
            {
                isEnable = false;
            }
            SetQUControlEnable(isEnable);
        }
        private void SetQUControlEnable(bool isEnble)
        {
            #region 龋齿左上
            this.SetControlEnable(cbb_qcl7top_1, isEnble);

            this.SetControlEnable(cbb_qcl6top_1, isEnble);

            this.SetControlEnable(cbb_qcl5top_1, isEnble);
            this.SetControlEnable(cbb_qcl5top, isEnble);

            this.SetControlEnable(cbb_qcl4top_1, isEnble);
            this.SetControlEnable(cbb_qcl4top, isEnble);

            this.SetControlEnable(cbb_qcl3top_1, isEnble);
            this.SetControlEnable(cbb_qcl3top, isEnble);

            this.SetControlEnable(cbb_qcl2top_1, isEnble);
            this.SetControlEnable(cbb_qcl2top, isEnble);

            this.SetControlEnable(cbb_qcl1top_1, isEnble);
            this.SetControlEnable(cbb_qcl1top, isEnble);
            #endregion

            #region 龋齿右上
            this.SetControlEnable(cbb_qcr7top_1, isEnble);

            this.SetControlEnable(cbb_qcr6top_1, isEnble);

            this.SetControlEnable(cbb_qcr5top_1, isEnble);
            this.SetControlEnable(cbb_qcr5top, isEnble);

            this.SetControlEnable(cbb_qcr4top_1, isEnble);
            this.SetControlEnable(cbb_qcr4top, isEnble);

            this.SetControlEnable(cbb_qcr3top_1, isEnble);
            this.SetControlEnable(cbb_qcr3top, isEnble);

            this.SetControlEnable(cbb_qcr2top_1, isEnble);
            this.SetControlEnable(cbb_qcr2top, isEnble);

            this.SetControlEnable(cbb_qcr1top_1, isEnble);
            this.SetControlEnable(cbb_qcr1top, isEnble);
            #endregion

            #region 龋齿左下
            this.SetControlEnable(cbb_qcl7bottom_1, isEnble);

            this.SetControlEnable(cbb_qcl6bottom_1, isEnble);

            this.SetControlEnable(cbb_qcl5bottom_1, isEnble);
            this.SetControlEnable(cbb_qcl5bottom, isEnble);

            this.SetControlEnable(cbb_qcl4bottom_1, isEnble);
            this.SetControlEnable(cbb_qcl4bottom, isEnble);

            this.SetControlEnable(cbb_qcl3bottom_1, isEnble);
            this.SetControlEnable(cbb_qcl3bottom, isEnble);

            this.SetControlEnable(cbb_qcl2bottom_1, isEnble);
            this.SetControlEnable(cbb_qcl2bottom, isEnble);

            this.SetControlEnable(cbb_qcl1bottom_1, isEnble);
            this.SetControlEnable(cbb_qcl1bottom, isEnble);
            #endregion

            #region 龋齿右下
            this.SetControlEnable(cbb_qcr7bottom_1, isEnble);

            this.SetControlEnable(cbb_qcr6bottom_1, isEnble);

            this.SetControlEnable(cbb_qcr5bottom_1, isEnble);
            this.SetControlEnable(cbb_qcr5bottom, isEnble);

            this.SetControlEnable(cbb_qcr4bottom_1, isEnble);
            this.SetControlEnable(cbb_qcr4bottom, isEnble);

            this.SetControlEnable(cbb_qcr3bottom_1, isEnble);
            this.SetControlEnable(cbb_qcr3bottom, isEnble);

            this.SetControlEnable(cbb_qcr2bottom_1, isEnble);
            this.SetControlEnable(cbb_qcr2bottom, isEnble);

            this.SetControlEnable(cbb_qcr1bottom_1, isEnble);
            this.SetControlEnable(cbb_qcr1bottom, isEnble);
            #endregion
        }

        private void SetControlEnable(System.Windows.Forms.Control control, bool isenble)
        {
            control.Enabled = isenble;
            if (!isenble)
            {
                control.Text = string.Empty;
            }
        }
        #endregion
        #endregion
        #region 牙龈相关方法
        #region 牙龈暂未检测
        private void chb_yy_CheckedChanged(object sender, EventArgs e)
        {
            bool isEnable = true;
            if (chb_yy.Checked)
            {
                isEnable = false;
            }
            this.SetControlEnable(this.cbb_yycbottom, isEnable);
            this.SetControlEnable(this.cbb_yyctop, isEnable);
            this.SetControlEnable(this.cbb_yylbottom, isEnable);
            this.SetControlEnable(this.cbb_yyltop, isEnable);
            this.SetControlEnable(this.cbb_yyrbottom, isEnable);
            this.SetControlEnable(this.cbb_yyrtop, isEnable);
        }
        #endregion
        #endregion
    }
}
