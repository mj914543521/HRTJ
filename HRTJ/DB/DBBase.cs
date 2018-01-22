using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Com.cn.DB
{
    public abstract class DBBase
    {
        private string _ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=HRWJ.mdb;Persist Security Info=True";

        public string ConnectionString
        {
            get { return _ConnectionString; }
            set { _ConnectionString = value; }
        }
        public string ConvertDateToString(DateTime time)
        {
            return time.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public string ConvertDateToString(DateTime time,string format)
        {
            return time.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public abstract DataTable Query(string sql);


        public abstract DataTable Query(string sql, DataTable table);

        public abstract int Update(string sql);

        public abstract string getUpdateSql(DataTable table, DataRow row,
            DataRow oldRow);

        public abstract string GetInsertSql(DataTable table, DataRow tableRow);
    }
}
