using System;
using System.Data;
using System.Windows.Forms;

using Com.cn.DB;
using Com.cn.HRWJDataSet;

namespace HRTJ.login
{
    public partial class Frm_login : Form
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

        public Frm_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = " select * from tb_user where name = '" + txt_name.Text + "' and password = '" + txt_pwd.Text + "'";

            HRWJAccessDataSet.tb_userDataTable userDataTable = new HRWJAccessDataSet.tb_userDataTable();

            DataTable table = DBSession.Query(sql, userDataTable);
            if (table!=null && table.Rows.Count>0)
            {
                TJXX.userDataTable = table as HRWJAccessDataSet.tb_userDataTable;
                this.Close();
            }
            else
            {
                if (DialogResult.Retry!=MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.RetryCancel))
                {
                    Application.Exit();       
                }
            }
           
        }
    }
}
