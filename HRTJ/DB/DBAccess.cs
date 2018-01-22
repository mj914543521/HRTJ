using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Text;
using Com.cn.Log;
using FW.Config;


namespace Com.cn.DB
{

    public class DBAccess : DBBase
    {
        
        public DBAccess()
        {
            this.ConnectionString = ConfigManager.GetAppConfig("AccessConnectionString"); 
        }
        public override DataTable Query(string sql)
        {   
            DataTable table = new DataTable();
            Query(sql, table);
            
            return table;
        }

        public override DataTable Query(string sql, DataTable table)
        {
            SqlLog.Debug("查询开始 ：" + sql);
            try
            {
                OleDbConnection conn = new OleDbConnection(ConnectionString);
                OleDbCommand command = new OleDbCommand();
                command.CommandText = sql;
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                adapter.Fill(table);
                conn.Close();
            }
            catch (System.Exception ex)
            {
                SqlLog.Error("查询失败 SQL：" + sql,ex);
                throw ex;
            }
            
            SqlLog.Debug("查询结束");
            return table;
        }
        public override int Update(string sql)
        {
            SqlLog.Debug("更新数据库开始 ：" + sql);
            DataTable table = new DataTable();
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            OleDbCommand command = new OleDbCommand();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            OleDbTransaction Transaction = conn.BeginTransaction();

            int count = 0;
            try
            {
                command.Connection = conn;
                command.Transaction = Transaction;

                command.CommandType = CommandType.Text;
                // Transaction.Begin();
                if (sql.LastIndexOf(";") >= 0)
                {
                    string[] strs = sql.Split(';');
                    if (strs != null && strs.Length > 0)
                    {
                        for (int i = 0; i < strs.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(strs[i].Trim()))
                            {
                                command.CommandText = strs[i].Trim();
                                count += command.ExecuteNonQuery();
                            }
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(sql.Trim()))
                    {
                        command.CommandText = sql.Trim();
                        count += command.ExecuteNonQuery();
                    }
                }
                Transaction.Commit();
            }
            catch (System.Exception ex)
            {
                Transaction.Rollback();
                SqlLog.Error("数据更新失败  SQL："+sql, ex);
            }
            finally
            {
                conn.Close();
            }
            SqlLog.Debug("更新数据库结束。");
            return count;
        }

        #region getsql
        public override string getUpdateSql(DataTable table, DataRow row,
            DataRow oldRow)
        {
            string sql = string.Empty;
            StringBuilder sb = new StringBuilder();
            StringBuilder updateContent = new StringBuilder();
            StringBuilder whereSql = new StringBuilder();

            sb.Append(" update " + table.TableName);
            sb.Append("    set ");
            string id = string.Empty;

            for (int i = 0; i < table.Columns.Count; i++)
            {
                string colValue = Convert.ToString(row[table.Columns[i].ColumnName]);

                string oldColValue = string.Empty;
                if (oldRow != null && oldRow.Table.Columns.Contains(table.Columns[i].ColumnName))
                {
                    oldColValue = Convert.ToString(oldRow[table.Columns[i].ColumnName]);
                }
                #region Update语句
                bool isupdate = false;
                if (colValue != oldColValue)
                {
                    isupdate = true;
                }

                string dataTypeName = table.Columns[i].DataType.Name.ToLower();
                if (isupdate)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(updateContent)))
                    {
                        if (string.IsNullOrEmpty(colValue) && table.Columns[i].AllowDBNull)
                        {
                            updateContent.Append(",[" + table.Columns[i].ColumnName + "] = NULL ");
                        }
                        else if (dataTypeName.Contains("int"))
                        {
                            updateContent.Append(",[" + table.Columns[i].ColumnName + "] = " + colValue);
                        }
                        else if (dataTypeName.Contains("date") || dataTypeName.Contains("time"))
                        {
                            updateContent.Append(",[" + table.Columns[i].ColumnName + "] = '"
                                + ConvertDateToString(Convert.ToDateTime(colValue)) + "'");
                        }
                        else
                        {
                            updateContent.Append(",[" + table.Columns[i].ColumnName + "] = '" + colValue + "'");
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(colValue) && table.Columns[i].AllowDBNull)
                        {
                            updateContent.Append(" [" + table.Columns[i].ColumnName + "] = NULL ");
                        }
                        else if (dataTypeName.Contains("int"))
                        {
                            updateContent.Append(" [" + table.Columns[i].ColumnName + "] = " + colValue);
                        }
                        else if (dataTypeName.Contains("date") || dataTypeName.Contains("time"))
                        {
                            updateContent.Append(" [" + table.Columns[i].ColumnName + "] = '"
                                + ConvertDateToString(Convert.ToDateTime(colValue)) + "'");
                        }
                        else
                        {
                            updateContent.Append(" [" + table.Columns[i].ColumnName + "] = '" + colValue + "'");
                        }
                    }
                }
                #endregion

                #region Where语句
                DataColumn[] primaryKeyCols = table.PrimaryKey;
                if (primaryKeyCols != null)
                {
                    for (int j = 0; j < primaryKeyCols.Length; j++)
                    {
                        if (primaryKeyCols[j].ColumnName.Equals(table.Columns[i].ColumnName))
                        {
                            if (!string.IsNullOrEmpty(colValue))
                            {
                                if (dataTypeName.LastIndexOf("int") >= 0)
                                {
                                    whereSql.Append(" and [" + table.Columns[i].ColumnName + "] = " + colValue);
                                }
                                else if (dataTypeName.Contains("date") || dataTypeName.Contains("time"))
                                {
                                    whereSql.Append(" and [" + table.Columns[i].ColumnName + "] = '" +
                                        ConvertDateToString(Convert.ToDateTime(colValue)) + "'");
                                }
                                else
                                {
                                    whereSql.Append(" and [" + table.Columns[i].ColumnName + "] = '" + colValue + "'");
                                }
                            }
                        }
                    }
                }
                #endregion
            }
            if (!string.IsNullOrEmpty(Convert.ToString(updateContent)))
            {
                sb.Append(Convert.ToString(updateContent));
                sb.Append(" where 1 = 1 ");
                string whereStr = whereSql.ToString();
                if (!string.IsNullOrEmpty(whereStr))
                {
                    sb.Append(whereStr);
                }
                return sb.ToString();
            }
            return sql;
        }

        public override string GetInsertSql(DataTable table, DataRow tableRow)
        {

            StringBuilder insertSql = new StringBuilder();
            insertSql.Append(" insert into " + table.TableName + " (");

            for (int i = 0; i < table.Columns.Count; i++)
            {
                if (i == 0)
                {
                    insertSql.Append("[" + table.Columns[i].ColumnName + "]");
                }
                else
                {
                    insertSql.Append(" , [" + table.Columns[i].ColumnName + "]");
                }
            }
            insertSql.Append(" ) ");

            insertSql.Append(" VALUES ( ");

            for (int i = 0; i < table.Columns.Count; i++)
            {
                string value = Convert.ToString(tableRow[table.Columns[i].ColumnName]);
                string dataTypeName = table.Columns[i].DataType.Name.ToLower();

                if (i == 0)
                {
                    #region 第一列的场合
                    if (dataTypeName.LastIndexOf("int") >= 0)
                    {
                        #region 整数类型
                        if (string.IsNullOrEmpty(value))
                        {
                            if (table.Columns[i].AllowDBNull)
                            {
                                insertSql.Append(" null ");
                            }
                            else
                            {
                                insertSql.Append(" 0 ");
                            }
                        }
                        else
                        {
                            insertSql.Append(value);
                        }
                        #endregion
                    }
                    else if (dataTypeName.Contains("date") || dataTypeName.Contains("time"))
                    {
                        #region 时间类型
                        if (string.IsNullOrEmpty(value))
                        {
                            if (table.Columns[i].AllowDBNull)
                            {
                                insertSql.Append(" null ");
                            }
                            else
                            {
                                insertSql.Append(" '" + ConvertDateToString(DateTime.MinValue) + "' ");
                            }
                        }
                        else
                        {
                            insertSql.Append(" '" + ConvertDateToString(Convert.ToDateTime(value)) + "' ");
                        }

                        #endregion
                    }
                    else
                    {
                        #region 非整数类型
                        if (string.IsNullOrEmpty(value))
                        {
                            if (table.Columns[i].AllowDBNull)
                            {
                                insertSql.Append(" null ");
                            }
                            else
                            {
                                insertSql.Append(" '' ");
                            }
                        }
                        else
                        {
                            insertSql.Append("'" + value + "' ");
                        }
                        #endregion
                    }
                    #endregion
                }
                else
                {
                    #region 除第一列外的其它列
                    if (dataTypeName.LastIndexOf("int") >= 0)
                    {
                        #region 整数类型
                        if (string.IsNullOrEmpty(value))
                        {
                            if (table.Columns[i].AllowDBNull)
                            {
                                insertSql.Append(", null ");
                            }
                            else
                            {
                                insertSql.Append(", 0 ");
                            }
                        }
                        else
                        {
                            insertSql.Append(" , " + value);
                        }
                        #endregion
                    }
                    else if (dataTypeName.Contains("date") || dataTypeName.Contains("time"))
                    {
                        #region 时间类型
                        if (string.IsNullOrEmpty(value))
                        {
                            if (table.Columns[i].AllowDBNull)
                            {
                                insertSql.Append(" , null ");
                            }
                            else
                            {
                                insertSql.Append(" , '" + ConvertDateToString(DateTime.MinValue) + "'");
                            }
                        }
                        else
                        {
                            insertSql.Append(" , '" + ConvertDateToString(Convert.ToDateTime(value)) + "'");
                        }
                        #endregion
                    }
                    else
                    {
                        #region 非整数类型
                        if (string.IsNullOrEmpty(value))
                        {
                            if (table.Columns[i].AllowDBNull)
                            {
                                insertSql.Append(" , null ");
                            }
                            else
                            {
                                insertSql.Append(" , '' ");
                            }
                        }
                        else
                        {
                            insertSql.Append(", '" + value + "' ");
                        }
                        #endregion
                    }
                    #endregion
                }
            }
            insertSql.Append(" ) ");
            insertSql.Append(";");
            
            return insertSql.ToString();
        }

        #endregion
    }
    
}
