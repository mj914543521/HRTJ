
using System.Windows.Forms;
using Com.cn.DB;
using Com.cn.HRWJDataSet;
namespace HRTJ.Base
{
    public partial class Control : UserControl
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

        public Control()
        {
            InitializeComponent();
        }


        public HRWJAccessDataSet.tb_studentexam_ClientDataTable studentexamDB = new HRWJAccessDataSet.tb_studentexam_ClientDataTable();
        private string _ID;
        public string ID
        {
            get { return _ID; }
            set
            {
                this._ID = value;
                HRWJAccessDataSet.tb_studentexam_ClientDataTable db = null;
                if (!string.IsNullOrEmpty(this._ID))
                {
                    db = getDataTable(this._ID);
                }
                HRWJAccessDataSet.tb_studentexam_ClientRow row = null;
                if (db != null && db.Rows.Count > 0)
                {
                    row = db.Rows[0] as HRWJAccessDataSet.tb_studentexam_ClientRow;
                }
                if (row != null)
                {
                    this.Init(row);
                }

            }
        }

        protected virtual HRWJAccessDataSet.tb_studentexam_ClientDataTable getDataTable(string id)
        {
            HRWJAccessDataSet.tb_studentexam_ClientDataTable studentexam = new HRWJAccessDataSet.tb_studentexam_ClientDataTable();
            string sql = " select * from tb_studentexam_Client where id= " + id;
            DBSession.Query(sql, studentexam);
            
            return studentexam;
        }

        public virtual void Init(HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
        }

        public virtual void CollectData(ref HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {

        }
    }
}
