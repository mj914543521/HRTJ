using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Com.cn.DB;
using Com.cn.HRWJDataSet;
using Com.cn.Log;
using Com.cn.SncData;

namespace HRTJ.Base
{
    public partial class Frm_Base : Form
    {
        public DBBase _DBSession;
        public DBBase DBSession
        {
            get
            {
                if (_DBSession == null)
                {
                    _DBSession = new DBAccess();
                };
                return _DBSession;
            }
        }

        private HRWJAccessDataSet.tb_configDataTable _configDataTable;

        public HRWJAccessDataSet.tb_configDataTable configDataTable
        {
            get
            {
                if (!(_configDataTable != null && _configDataTable.Rows.Count > 0))
                {
                    _configDataTable = new HRWJAccessDataSet.tb_configDataTable();
                    DBSession.Query(" select * from tb_config where configkey='alter_timeout' ", _configDataTable);
                }
                return _configDataTable;
            }
        }

        public Frm_Base()
        {
            InitializeComponent();
        }
        #region 保存
        private void btn_Save_Click(object sender, EventArgs e)
        {
            int num = Save();
            if (num > 0)
            {
                this.Close();
            }
        }
        public virtual int Save()
        {
            OperationLog.Debug("体检信息开始保存");
            int count = 0;
            StringBuilder sqlsb = new StringBuilder();
            HRWJAccessDataSet.tb_studentexam_ClientRow row = UserControl_TJXX.studentexamRow;
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                string sql = this.Save(control, ref row);
                if (!string.IsNullOrEmpty(sql) && !sqlsb.ToString().Contains(sql))
                {
                    sqlsb.AppendLine(sql);
                }
            }
            SqlLog.Debug("体检信息保存SQL:" + sqlsb.ToString());
            count = DBSession.Update(sqlsb.ToString());
            OperationLog.Debug("体检信息保存成功。更新" + count + "条数据。");
            return count;
            
        }

        public virtual string Save(System.Windows.Forms.Control Control, ref HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            StringBuilder sqlsb = new StringBuilder();

            if (Control is Control)
            {
                sqlsb.AppendLine(getSql((Control)Control, ref row));
            }

            foreach (System.Windows.Forms.Control control in Control.Controls)
            {
                string str = this.Save(control, ref row);
                if (!string.IsNullOrEmpty(str) && !(Control is Control))
                {
                    sqlsb.AppendLine(str);
                }
            }

            return sqlsb.ToString();
        }

        private string getSql(Control userControl,
            ref HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            HRWJAccessDataSet.tb_studentexam_ClientDataTable table = new HRWJAccessDataSet.tb_studentexam_ClientDataTable();
            userControl.CollectData(ref row);
            StringBuilder sqlsb = new StringBuilder();
            string sql = DBSession.getUpdateSql(table, row, UserControl_TJXX.studentexamRow);

            if (!string.IsNullOrEmpty(sql))
            {
                if (!sqlsb.ToString().Contains(sql))
                {
                    sqlsb.AppendLine(sql + " ; ");

                    sqlsb.AppendLine(" update tb_studentexam_Client set tjrq ='" + DBSession.ConvertDateToString(DateTime.Now) + "' where id =" + row.id + " and tjrq is null ;");
                    sqlsb.AppendLine(" update tb_studentexam_Client set sncID ='" + Guid.NewGuid().ToString() + "' where id =" + row.id + " ; ");
                    sqlsb.AppendLine(" update tb_studentexam_Client set updatetime ='" + DBSession.ConvertDateToString(DateTime.Now) + "' where id =" + row.id + " ; ");
                }
            }
            return sqlsb.ToString();
        }
        #endregion

        #region 关闭
        private void btn_Colse_Click(object sender, EventArgs e)
        {
            this.ColseForm();
        }

        public virtual int ColseForm()
        {
            this.Close();
            return 0;
        }
        #endregion



        private void Frm_Base_Load(object sender, EventArgs e)
        {
            this.Text = "北京市中小学健康信息管理系统" + "—" + this.Text;
            if (!DesignMode)
            {
                if (configDataTable != null && configDataTable.Rows.Count > 0)
                {
                    string alterTimeout =
                        Convert.ToString(configDataTable.Rows[0][configDataTable.configvalueColumn.ColumnName]);
                    int alterTimeoutInt = 0;
                    int.TryParse(alterTimeout, out alterTimeoutInt);
                    HRWJAccessDataSet.tb_studentexam_ClientDataTable studentexamDataTable
                        = new HRWJAccessDataSet.tb_studentexam_ClientDataTable();

                    HRWJAccessDataSet.tb_studentexam_ClientRow row = UserControl_TJXX.studentexamRow;
                    string tjrq =
                        Convert.ToString(row[studentexamDataTable.tjrqColumn.ColumnName]);
                    if (!string.IsNullOrEmpty(tjrq))
                    {
                        if (UserControl_TJXX.studentexamRow.tjrq.AddDays(alterTimeoutInt) < DateTime.Now)
                        {
                            this.btn_Save.Enabled = false;
                        }
                    }


                    if (!row.IstjrqNull() && row.IssncIDNull())
                    {
                        this.btn_Save.Enabled = false;
                    }
                }

            }
        }
    }
}
