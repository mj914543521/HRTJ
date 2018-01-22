using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Com.cn.DB;
using Com.cn.HRWJDataSet;
using Com.cn.Log;
using FW.Config;

namespace Com.cn.MySqlData
{
    public class DealMySql
    {
        public DB.DBBase _DBSession;
        public DB.DBBase DBSession
        {
            get
            {
                if (_DBSession == null)
                {
                    _DBSession = new DBMySql();
                };
                return _DBSession;
            }
        }


        public HRWJMySqlDataSet.tb_configDataTable GetConfigData()
        {
            OperationLog.Info("开始获取服务器tb_config数据");
            HRWJMySqlDataSet.tb_configDataTable table = new HRWJMySqlDataSet.tb_configDataTable();
            DBSession.Query(" select * from tb_config ", table);
            if (table!=null && table.Rows.Count>0)
            {
                OperationLog.Info("获取tb_config服务器数据" + table.Rows.Count + "条");
            }
            else
            {
                OperationLog.Info("获取tb_config服务器数据0条");
            }
            
            return table;
        }


        public HRWJMySqlDataSet.tb_userDataTable GetUserData()
        {
            OperationLog.Info("开始获取服务器tb_user数据");
            HRWJMySqlDataSet.tb_userDataTable table = new HRWJMySqlDataSet.tb_userDataTable();
            DBSession.Query(" select * from tb_user ", table);
            
            if (table != null && table.Rows.Count > 0)
            {
                OperationLog.Info("获取tb_user服务器数据" + table.Rows.Count + "条");
            }
            else
            {
                OperationLog.Info("获取tb_user服务器数据0条");
            }
            return table;
        }


        public HRWJMySqlDataSet.tb_officeDataTable GetofficeData()
        {
            OperationLog.Info("开始获取服务器tb_office数据");
            HRWJMySqlDataSet.tb_officeDataTable table = new HRWJMySqlDataSet.tb_officeDataTable();
            DBSession.Query(" select * from tb_office ", table);
            if (table != null && table.Rows.Count > 0)
            {
                OperationLog.Info("获取tb_office服务器数据" + table.Rows.Count + "条");
            }
            else
            {
                OperationLog.Info("获取tb_office服务器数据0条");
            }
            return table;
        }


        public HRWJMySqlDataSet.tb_studentexamDataTable GetStudentexamData()
        {
            OperationLog.Info("开始获取服务器tb_studentexam数据");
            string sql = " select * from tb_studentexam ";
            HRWJMySqlDataSet.tb_studentexamDataTable table = new HRWJMySqlDataSet.tb_studentexamDataTable();
            DBSession.Query(sql, table);
            if (table != null && table.Rows.Count > 0)
            {
                OperationLog.Info("获取tb_studentexam服务器数据" + table.Rows.Count + "条");
            }
            else
            {
                OperationLog.Info("获取tb_studentexam服务器数据0条");
            }
            return table;
        }


        public int UpdateStudentexamData(HRWJMySqlDataSet.tb_studentexamDataTable table,
            HRWJMySqlDataSet.tb_studentexamDataTable tableAccessServer)
        {
            OperationLog.Info("开始更新服务器tb_studentexam数据");

            StringBuilder sb = new StringBuilder();
            foreach (HRWJMySqlDataSet.tb_studentexamRow row in table.Rows)
            {
                string sql = GetUpdateSqlFromStudentRow(row, tableAccessServer);
                if (!string.IsNullOrEmpty(sql.Trim()))
                {
                    sb.AppendLine(sql + " ; ");
                }
            }
            int count = DBSession.Update(sb.ToString());
            SystemLog.Info("更新服务器tb_studentexam数据SQl:" + sb.ToString());
            string updateColumnDefaultValue = ConfigManager.GetAppConfig("UpdateColumnDefaultValue");
            DBSession.Update(updateColumnDefaultValue);
            OperationLog.Info("成功更新服务器tb_studentexam数据" + count + "条。");
            return count;
        }

        #region 更新体检数据
        private string GetUpdateSqlFromStudentRow(HRWJMySqlDataSet.tb_studentexamRow clientRow,
            HRWJMySqlDataSet.tb_studentexamDataTable tableAccessServer)
        {
            HRWJMySqlDataSet.tb_studentexamDataTable table = new HRWJMySqlDataSet.tb_studentexamDataTable();
            string sql = string.Empty;
            bool isupdate = isUpdateServerDate(clientRow);
            if (isupdate)
            {
                DataRow[] rows = tableAccessServer.Select("id = " + clientRow.id);
                if (rows != null && rows.Length > 0)
                {
                    sql = DBSession.getUpdateSql(table, clientRow, rows[0]);
                }
                return sql;
            }
            
            return string.Empty;
        }

        private bool isUpdateServerDate(HRWJMySqlDataSet.tb_studentexamRow clientRow)
        {
            if (clientRow != null)
            {
                HRWJMySqlDataSet.tb_studentexamDataTable serverData = new HRWJMySqlDataSet.tb_studentexamDataTable();
                string id = Convert.ToString(clientRow[serverData.idColumn.ColumnName]);
                DBSession.Query(" select * from tb_studentexam where id =" + id, serverData);
                
                if (!clientRow.IstjrqNull()
                    && serverData != null
                    && serverData.Rows.Count > 0)
                {
                    HRWJMySqlDataSet.tb_studentexamRow serverRow = (HRWJMySqlDataSet.tb_studentexamRow)serverData.Rows[0]; 
                    // 客户端体检日期为null 或者体检日期不为null并且
                    if (serverRow.IstjrqNull() || !clientRow.IssncIDNull())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion

    }
}
