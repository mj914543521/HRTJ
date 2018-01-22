using System;
using System.Data;
using System.Text;
using Com.cn.DB;
using Com.cn.HRWJDataSet;
using Com.cn.Log;
using Com.cn.MySqlData;

namespace Com.cn.SncData
{
    public class SncData
    {
        public DB.DBBase _DBSession;
        public DB.DBBase DBSession
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

        public SncData()
        {
            
        }

        public void SncUserClientData()
        {
            try
            {
                OperationLog.Info("开始更新客户端数据");

                //UpStudentexamData();
                //DownDataStudentexam();
                SncDataConfig();
                SncDataOffice();
                SncDataUser();
                
                OperationLog.Info("成功更新客户端数据");
            }
            catch (Exception ex)
            {
                OperationLog.Error("更新数据失败", ex);
            }
        }
        /// <summary>
        /// 上传Studentexam数据
        /// </summary>
        /// <param name="client"></param>
        public void UpStudentexamData()
        {
            DealMySql client = new DealMySql();
            #region 上传数据
            OperationLog.Info("开始上传tb_studentexam数据");
            HRWJAccessDataSet.tb_studentexam_ClientDataTable accessStudentexam_Client
                = new HRWJAccessDataSet.tb_studentexam_ClientDataTable();
            OperationLog.Info("开始获取客户端tb_studentexam数据");
            DBSession.Query(" select * from tb_studentexam_Client where tjrq is not null and sncID is not null ", accessStudentexam_Client);
            if (null != accessStudentexam_Client && accessStudentexam_Client.Rows.Count > 0)
            {
                OperationLog.Info("成功获取客户端tb_studentexam数据" + accessStudentexam_Client.Rows.Count + "条");
            }
            else
            {
                OperationLog.Info("成功获取客户端tb_studentexam数据0条");
            }

            HRWJMySqlDataSet.tb_studentexamDataTable tb_studentexamClient = new HRWJMySqlDataSet.tb_studentexamDataTable();
            tb_studentexamClient = ConvertTable(accessStudentexam_Client, tb_studentexamClient) as HRWJMySqlDataSet.tb_studentexamDataTable;
            // 客户端的服务器数据
            HRWJAccessDataSet.tb_studentexamDataTable accessStudentexam_Server
                = new HRWJAccessDataSet.tb_studentexamDataTable();
            DBSession.Query(" select * from tb_studentexam ", accessStudentexam_Server);

            HRWJMySqlDataSet.tb_studentexamDataTable tb_studentexamServer = new HRWJMySqlDataSet.tb_studentexamDataTable();
            tb_studentexamServer = ConvertTable(accessStudentexam_Server, tb_studentexamServer) as HRWJMySqlDataSet.tb_studentexamDataTable;

            int count = client.UpdateStudentexamData(tb_studentexamClient, tb_studentexamServer);
            OperationLog.Info("成功上传tb_studentexam数据" + count + "条");
            #endregion
        }


        public void snyStudentexam_ClientData()
        {
            StringBuilder sqlsb = new StringBuilder();
            sqlsb.AppendLine("delete from tb_studentexam_Client ;");
            sqlsb.AppendLine("insert into tb_studentexam_Client select * from tb_studentexam ;");
            DBSession.Update(sqlsb.ToString());
            /*
            // 客户端的服务器数据
            HRWJAccessDataSet.tb_studentexamDataTable accessStudentexam_Server
                = new HRWJAccessDataSet.tb_studentexamDataTable();
            
            DBSession.Query(" select * from tb_studentexam ", accessStudentexam_Server);

            HRWJAccessDataSet.tb_studentexam_ClientDataTable accessStudentexam_Client
                = new HRWJAccessDataSet.tb_studentexam_ClientDataTable();
            DBSession.Query(" select * from tb_studentexam_Client ", accessStudentexam_Client);
            if (accessStudentexam_Server!=null && accessStudentexam_Server.Rows.Count>0)
            {
                for (int i = 0; i < accessStudentexam_Server.Rows.Count; i++)
                {
                    string sql = string.Empty;

                    string id = Convert.ToString(accessStudentexam_Server.Rows[i][accessStudentexam_Server.idColumn.ColumnName]);
                    DataRow[] rows = accessStudentexam_Client.Select(" id =" + id);

                    if (rows != null && rows.Length > 0)
                    {
                        sql = DBSession.getUpdateSql(accessStudentexam_Client,
                            accessStudentexam_Server.Rows[i],
                            rows[0]);
                    }
                    else
                    {
                        sql = DBSession.GetInsertSql(accessStudentexam_Client, accessStudentexam_Server.Rows[i]);
                    }
                    if (!string.IsNullOrEmpty(sql.Trim()))
                    {
                        sqlsb.AppendLine(sql + " ; ");    
                    }
                }
            }

            DBSession.Update(sqlsb.ToString());
            accessStudentexam_Server = new HRWJAccessDataSet.tb_studentexamDataTable();
            accessStudentexam_Client
                = new HRWJAccessDataSet.tb_studentexam_ClientDataTable();
            DBSession.Query(" select * from tb_studentexam ", accessStudentexam_Server);
            DBSession.Query(" select * from tb_studentexam_Client ", accessStudentexam_Client);
            if (accessStudentexam_Client != null && accessStudentexam_Client.Rows.Count > 0)
            {
                sqlsb = new StringBuilder();
                for (int i = 0; i < accessStudentexam_Client.Rows.Count; i++)
                {
                    string id = Convert.ToString(accessStudentexam_Client.Rows[i][accessStudentexam_Client.idColumn.ColumnName]);
                    DataRow[] rows = accessStudentexam_Server.Select(" id =" + id);
                    if (!(rows != null && rows.Length > 0))
                    {
                        sqlsb.AppendLine("delete from tb_studentexam_Client where id= " + id + ";");
                    }
                }
                DBSession.Update(sqlsb.ToString());
            }
            */


        }

        public void DownDataStudentexam()
        {
            DealMySql client = new DealMySql();
            #region 下载数据
            OperationLog.Info("开始下载tb_studentexam数据");
            HRWJMySqlDataSet.tb_studentexamDataTable tb_studentexam = new HRWJMySqlDataSet.tb_studentexamDataTable();
            HRWJAccessDataSet.tb_studentexamDataTable accessStudentexam
                = new HRWJAccessDataSet.tb_studentexamDataTable();

            tb_studentexam = new HRWJMySqlDataSet.tb_studentexamDataTable();
            tb_studentexam = client.GetStudentexamData();
            
            accessStudentexam
                = new HRWJAccessDataSet.tb_studentexamDataTable();

            accessStudentexam =
                ConvertTable(tb_studentexam, accessStudentexam) as HRWJAccessDataSet.tb_studentexamDataTable;

            HRWJAccessDataSet.tb_studentexamDataTable studentexamDataTableOld
                            = new HRWJAccessDataSet.tb_studentexamDataTable();
            DBSession.Query(" select * from tb_studentexam ", studentexamDataTableOld);
            int count = 0;
            int rowCount=0;
            StringBuilder sqlInsert = new StringBuilder();
            if (accessStudentexam != null && accessStudentexam.Rows.Count > 0)
            {
                for (int i = 0; i < accessStudentexam.Rows.Count; i++)
                {
                    string sncID = Convert.ToString(
                        accessStudentexam.Rows[i][accessStudentexam.sncIDColumn.ColumnName]);

                    string tjrq = string.Empty;
                    if (!accessStudentexam.Rows[i].IsNull(accessStudentexam.tjrqColumn.ColumnName))
                    {
                        tjrq = DBSession.ConvertDateToString(
                            Convert.ToDateTime(accessStudentexam.Rows[i][accessStudentexam.tjrqColumn.ColumnName]));
                    }

                    string id = Convert.ToString(accessStudentexam.Rows[i][accessStudentexam.idColumn.ColumnName]);

                    DateTime tjrqDate = DateTime.MinValue;
                    bool tjrqBool = DateTime.TryParse(tjrq, out tjrqDate);

                    if (string.IsNullOrEmpty(sncID.Trim()) && tjrqBool == false)
                    {
                        // 已体检，但是不是客户端上传的数据。
                        // 客户端未上传过的数据
                        accessStudentexam.Rows[i][accessStudentexam.sncIDColumn.ColumnName]
                            = System.Guid.NewGuid();
                    }

                    DataRow[] rows = studentexamDataTableOld.Select(" id =" + id);

                    if (rows != null && rows.Length > 0)
                    {
                        string sql = DBSession.getUpdateSql(accessStudentexam,
                            accessStudentexam.Rows[i],
                            rows[0]);

                        if (!string.IsNullOrEmpty(sql))
                        {
                            sqlInsert.AppendLine(sql + " ; ");
                        }
                        rowCount++;
                    }
                    else
                    {
                        rowCount++;
                        sqlInsert.AppendLine(DBSession.GetInsertSql(accessStudentexam, accessStudentexam.Rows[i]));
                    }
                    if (rowCount>5000)
                    {
                        count += DBSession.Update(sqlInsert.ToString());
                        sqlInsert = new StringBuilder();
                        rowCount = 0;
                    }
                }
                if (!string.IsNullOrEmpty(sqlInsert.ToString()))
                {
                    count += DBSession.Update(sqlInsert.ToString());
                    sqlInsert = new StringBuilder();
                }
            }
            snyStudentexam_ClientData();
            OperationLog.Info("成功下载tb_studentexam数据" + count.ToString() + "条");
            #endregion
        }

        public void SncDataUser()
        {
            DealMySql client = new DealMySql();
            #region 下载数据
            OperationLog.Info("开始同步tb_user数据");
            HRWJMySqlDataSet.tb_userDataTable userTable = new HRWJMySqlDataSet.tb_userDataTable();
            userTable = client.GetUserData();
            
            HRWJAccessDataSet.tb_userDataTable accessUserTable
                = new HRWJAccessDataSet.tb_userDataTable();

            HRWJAccessDataSet.tb_userDataTable accessUserTableOld
                = new HRWJAccessDataSet.tb_userDataTable();

            DBSession.Update(" delete from tb_user where name = 'offlineadmin' ");

            DBSession.Query(" select * from tb_user ", accessUserTableOld);

            accessUserTable =
                ConvertTable(userTable, accessUserTable) as HRWJAccessDataSet.tb_userDataTable;
            
            StringBuilder sqlSnc = new StringBuilder();
            int count = 0;
            int maxID = 0;
            if (accessUserTable != null && accessUserTable.Rows.Count > 0)
            {
                for (int i = 0; i < accessUserTable.Rows.Count; i++)
                {
                    string id = Convert.ToString(accessUserTable.Rows[i][accessUserTable.idColumn.ColumnName]);
                    int idint = 0;
                    int.TryParse(id, out idint);
                    if (idint>maxID)
                    {
                        maxID = idint;
                    }
                    DataRow[] oldRows = accessUserTableOld.Select(" id =" + id);
                    string sql = string.Empty;
                    if (oldRows != null && oldRows.Length > 0)
                    {
                        sql = DBSession.getUpdateSql(accessUserTable, accessUserTable.Rows[i], oldRows[0]);
                    }
                    else
                    {
                        sql = DBSession.GetInsertSql(accessUserTable, accessUserTable.Rows[i]);
                    }
                    if (!string.IsNullOrEmpty(sql))
                    {
                        sqlSnc.AppendLine(sql + " ; ");
                    }
                }
            }
            count = DBSession.Update(sqlSnc.ToString());

            DataRow[] rows = accessUserTableOld.Select(" name = 'offlineadmin' ");
            if (!(rows != null && rows.Length > 0))
            {
                //string sql = @"INSERT INTO tb_user (name, password, flag, nickname, officeid, userimg, votenum)
                //               VALUES ('offlineadmin', '123456', 1, 'offlineadmin', 0, NULL, NULL)";
                maxID = maxID + 1;
                string sql = @"insert into tb_user ([id] , [name] , [password] , [flag] , [nickname] , [officeid] , [userimg] , [votenum] )  VALUES ( "+ maxID + @", 'offlineadmin' , '123456'  , 1, '管理员' , null , ''  , 0 )";
                DBSession.Update(sql.ToString());
            }

           
            OperationLog.Info("同步tb_user数据" + count.ToString() + "条");
            #endregion
        }

        public void SncDataConfig()
        {
            DealMySql client = new DealMySql();
            #region 下载数据
            OperationLog.Info("开始同步tb_config数据");
            HRWJMySqlDataSet.tb_configDataTable configTable =
                new HRWJMySqlDataSet.tb_configDataTable();

            configTable = client.GetConfigData();

            HRWJAccessDataSet.tb_configDataTable accessConfigTable
                = new HRWJAccessDataSet.tb_configDataTable();

            HRWJAccessDataSet.tb_configDataTable accessConfigTableOld
                = new HRWJAccessDataSet.tb_configDataTable();
            
            DBSession.Query(" select * from tb_config ", accessConfigTableOld);
            

            accessConfigTable =
                ConvertTable(configTable, accessConfigTable) as HRWJAccessDataSet.tb_configDataTable;
            
            int count = 0;
            StringBuilder sqlSnc = new StringBuilder();
            if (accessConfigTable != null && accessConfigTable.Rows.Count > 0)
            {
                for (int i = 0; i < accessConfigTable.Rows.Count; i++)
                {
                    string id = Convert.ToString(accessConfigTable.Rows[i][accessConfigTable.idColumn.ColumnName]);
                    DataRow[] oldRows = accessConfigTableOld.Select(" id =" + id);
                    string sql = string.Empty;
                    if (oldRows != null && oldRows.Length > 0)
                    {
                        sql = DBSession.getUpdateSql(accessConfigTable, accessConfigTable.Rows[i], oldRows[0]);
                    }
                    else
                    {
                        sql = DBSession.GetInsertSql(accessConfigTable, accessConfigTable.Rows[i]);
                    }
                    if (!string.IsNullOrEmpty(sql))
                    {
                        sqlSnc.AppendLine(sql + " ; ");
                    }
                }
            }
            count = DBSession.Update(sqlSnc.ToString());
            OperationLog.Info("同步tb_config数据" + count.ToString() + "条");
            #endregion
        }

        public void SncDataOffice()
        {
            DealMySql client = new DealMySql();
            #region 下载数据
            OperationLog.Info("开始同步tb_office数据");
            HRWJMySqlDataSet.tb_officeDataTable officeTable = new HRWJMySqlDataSet.tb_officeDataTable();
            officeTable = client.GetofficeData();

            HRWJAccessDataSet.tb_officeDataTable accessOfficeTable
                = new HRWJAccessDataSet.tb_officeDataTable();

            HRWJAccessDataSet.tb_officeDataTable accessOfficeTableOld
                = new HRWJAccessDataSet.tb_officeDataTable();
            
            DBSession.Query(" select * from tb_office ", accessOfficeTableOld);

            accessOfficeTable =
                ConvertTable(officeTable, accessOfficeTable) as HRWJAccessDataSet.tb_officeDataTable;

            int count = 0;
            StringBuilder sqlSnc = new StringBuilder();
            if (accessOfficeTable != null && accessOfficeTable.Rows.Count > 0)
            {
                for (int i = 0; i < accessOfficeTable.Rows.Count; i++)
                {
                    string id = Convert.ToString(accessOfficeTable.Rows[i][accessOfficeTable.idColumn.ColumnName]);
                    DataRow[] oldRows = accessOfficeTableOld.Select(" id =" + id);
                    string sql = string.Empty;
                    if (oldRows != null && oldRows.Length > 0)
                    {
                        sql = DBSession.getUpdateSql(accessOfficeTable, accessOfficeTable.Rows[i], oldRows[0]);
                    }
                    else
                    {
                        sql = DBSession.GetInsertSql(accessOfficeTable, accessOfficeTable.Rows[i]);
                    }
                    if (!string.IsNullOrEmpty(sql))
                    {
                        sqlSnc.AppendLine(sql + " ; ");
                    }
                }
            }
            count = DBSession.Update(sqlSnc.ToString());
            OperationLog.Info("同步tb_office数据" + count.ToString() + "条");
            #endregion
        }

        private DataTable ConvertTable(DataTable origTable, DataTable newTable)
        {
            if (origTable != null && origTable.Rows.Count > 0)
            {
                for (int i = 0; i < origTable.Rows.Count; i++)
                {
                    DataRow newRow
                        = newTable.NewRow();

                    foreach (DataColumn col in origTable.Columns)
                    {
                        if (newTable.Columns.Contains(col.ColumnName))
                        {
                            string datatype = newTable.Columns[col.ColumnName].DataType.ToString().ToLower();
                            if (datatype.Contains("date") || datatype.Contains("time"))
                            {
                                DateTime time = DateTime.MinValue;
                                string value = Convert.ToString(origTable.Rows[i][col.ColumnName]);
                                if (DateTime.TryParse(value, out time))
                                {
                                    newRow[col.ColumnName] = value;
                                }
                                else
                                {
                                    if (!string.IsNullOrEmpty(value))
                                    {
                                        OperationLog.Warn("表" + origTable.TableName + "中含有非法时间。 非法值：" + value);
                                    }
                                }
                            }
                            else
                            {
                                newRow[col.ColumnName] = origTable.Rows[i][col.ColumnName];
                            }

                        }
                    }
                    newTable.Rows.Add(newRow);
                }
            }
            return newTable;
        }
    }
}
