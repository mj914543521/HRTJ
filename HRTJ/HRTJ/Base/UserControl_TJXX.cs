using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Com.cn.DB;
using Com.cn.HRWJDataSet;
using Com.cn.Log;

namespace HRTJ.Base
{
    public partial class UserControl_TJXX : Control
    {

        private static HRWJAccessDataSet.tb_studentexam_ClientRow _studentexamRow=null;
        public static HRWJAccessDataSet.tb_studentexam_ClientRow studentexamRow { 
            get {
                if (!string.IsNullOrEmpty(UserControl_TJXX._DataGridKey))
                {
                    HRWJAccessDataSet.tb_studentexam_ClientDataTable table = new HRWJAccessDataSet.tb_studentexam_ClientDataTable();
                    Control control = new Control();
                    control.DBSession.Query("select * from tb_studentexam_Client where id =" + UserControl_TJXX._DataGridKey, table);
                    if (null!=table&& table.Rows.Count>0)
                    {
                        _studentexamRow = table.Rows[0] as HRWJAccessDataSet.tb_studentexam_ClientRow;
                    }
                }
                return _studentexamRow; 
            }
        }

        public static string _DataGridKey;
        public string DataGridKey
        {
            get
            {
                if (string.IsNullOrEmpty(_DataGridKey))
                {
                    if (dataGrid.Rows.Count>0)
                    {
                        _DataGridKey = Convert.ToString(dataGrid.Rows[0].Cells[0].Value);    
                    }
                };
                return _DataGridKey;
            }
            set { _DataGridKey=value;} 
        }

        public UserControl_TJXX()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        private void UserControl_TJXX_Load(object sender, EventArgs e)
        {
            this.txt_cmisno.TextChanged += new System.EventHandler(this.txt_cmisno_TextChanged);
            this.cbb_School.TextChanged += new System.EventHandler(this.cbb_School_SelectedValueChanged);
            this.cbb_grade.TextChanged += new System.EventHandler(this.cbb_grade_SelectedValueChanged);
            this.cbb_class.TextChanged += new System.EventHandler(this.cbb_class_TextChanged);
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            pagerControl1.OnPageChanged += new EventHandler(pagerControl1_OnPageChanged);
            
            this.dataGrid.CellClick += dataGrid_CellClick;

        }


        public void initComBox()
        {
            initcbb_School();
            initcbb_grade();
            initcbb_class();
        }

        private void initcbb_School()
        {
            string sql = " SELECT distinct school FROM tb_studentexam_Client ";
            sql += " order by school desc ";

            DataTable table = DBSession.Query(sql);

            this.BindComBox(cbb_School, table);
        }

        private void initcbb_grade()
        {
            string sql = " SELECT distinct grade FROM tb_studentexam_Client where 1=1 ";
            if (!string.IsNullOrEmpty(cbb_School.Text))
            {
                sql += " and school like '%" + cbb_School.Text+"%'";
            }
            sql += " order by grade desc ";
            DataTable table = DBSession.Query(sql);

            this.BindComBox(cbb_grade, table);

        }

        private void initcbb_class()
        {
            string sql = " SELECT distinct classes FROM tb_studentexam_Client where 1=1 ";
            if (!string.IsNullOrEmpty(cbb_School.Text))
            {
                sql += " and school like '%" + cbb_School.Text + "%'";
            }

            if (!string.IsNullOrEmpty(cbb_grade.Text))
            {
                sql += " and grade like '%" + cbb_grade.Text + "%'";
            }

            sql += " order by classes desc ";

            

            DataTable table = DBSession.Query(sql);

            this.BindComBox(cbb_class, table);
        }

        private void BindComBox(ComboBox cob, DataTable table)
        {
            cob.Items.Clear();
            cob.Items.Add("");
            if (table !=null && table.Rows.Count>0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    cob.Items.Add(Convert.ToString(table.Rows[i][0]));
                }
            }
        }

        void pagerControl1_OnPageChanged(object sender, EventArgs e)
        {
            initGridView("");
        }
        public void initGridView(string whereSql )
        {
            
           string sql = @"SELECT top {PageSize}  id, name AS 姓名, sex AS 性别, classes AS 班级, grade AS 年级, school AS 学校, educationid AS 教育ID, jwbs AS 既往病史, 
                tjrq AS 体检日期, sg AS 身高, tz AS 体重, fhl AS 肺活量, xss AS 血色素, ssy AS 收缩压, szy AS 舒张压, 
                lyslleft AS 裸眼视力左, lyslright AS 裸眼视力右, sy AS 沙眼, sj AS 色觉, xz AS 心脏, f AS 肺, gp AS 肝脾, tj AS 头颈, 
                jz AS 脊柱, szgj AS 四肢关节, pf AS 皮肤, xb AS 胸部, jmy AS 结膜炎
                FROM      tb_studentexam_Client where 1=1 {where}  ";
           string where= GridViewWhere();
           
            if (!string.IsNullOrEmpty(whereSql))
            {
                where += whereSql;
            }

            #region 绘制分页控件
            string sqlCount = "select count(ID) from tb_studentexam_Client where 1=1 {where} ";
            sqlCount = sqlCount.Replace("{where}", where);
            DataTable tableCount = DBSession.Query(sqlCount);
            int count = 0;
            if (tableCount != null && tableCount.Rows.Count>0)
            {
                int.TryParse(Convert.ToString(tableCount.Rows[0][0]), out count);
                this.pagerControl1.DrawControl(count);
            }
            #endregion
            //if (this.pagerControl1.PageIndex > 1)
            //{
            //    sql += @"and id not in (
            //                    select top {PageSize*(PageIndex-1)}  ID 
            //                      from tb_studentexam_Client where 1=1 {where} {orderBy})";
            //}
            if (this.pagerControl1.PageIndex > 1)
            {
                string sqlmax = "select max(ID) from  (select top {PageSize*(PageIndex-1)} ID from tb_studentexam_Client order by id)";

                sqlmax = sqlmax.Replace("{PageSize*(PageIndex-1)}", (this.pagerControl1.PageSize * (this.pagerControl1.PageIndex - 1)).ToString());
                DataTable tableMax = DBSession.Query(sqlmax);
                int maxID = 0;
                if (tableMax != null && tableMax.Rows.Count > 0)
                {
                    // maxID= tableMax.Rows[0][0]
                    int.TryParse(Convert.ToString(tableMax.Rows[0][0]), out maxID);
                    where = where + "and id >" + maxID;
                }
            }


            sql += " {orderBy}";

            string orderBy = " order by school,grade,classes";
            orderBy = string.Empty;

            sql = sql.Replace("{PageSize}", this.pagerControl1.PageSize.ToString());
            sql = sql.Replace("{where}", where);
            sql = sql.Replace("{PageSize*(PageIndex-1)}", (this.pagerControl1.PageSize*(this.pagerControl1.PageIndex-1)).ToString());
            sql = sql.Replace("{orderBy}", orderBy);
            string oldDataGridKey = DataGridKey;
            
               

            DataTable table = DBSession.Query(sql);
           
             this.dataGrid.DataSource = table;
             if (this.dataGrid != null)
             {
                 this.dataGrid.Columns["id"].Visible = false;
                 this.dataGrid.EnableHeadersVisualStyles = false;
                 this.dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
                 this.dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
             }
             if (this.dataGrid !=null && this.dataGrid.Rows.Count>0)
             {
                bool isSelect = false;
                 for (int i = 0; i < this.dataGrid.Rows.Count; i++)
                 {
                     string id = Convert.ToString(this.dataGrid.Rows[i].Cells["id"].Value);
                    if (!string.IsNullOrEmpty(oldDataGridKey)
                        && oldDataGridKey.Equals(id))
                    {
                        this.dataGrid.Rows[i].Cells[1].Selected = true;
                        this.dataGrid.Rows[i].Selected = true;
                        isSelect = true;
                        break;
                    }
                 }
                if (!isSelect)
                {
                    this.dataGrid.Rows[0].Cells[1].Selected = true;
                    this.dataGrid.Rows[0].Selected = true;
                    isSelect = true;
                }
             }
        }

        public string GridViewWhere()
        {
            StringBuilder sqlWhere = new StringBuilder();
            if (!string.IsNullOrEmpty(txt_cmisno.Text.Trim()))
            {
                sqlWhere.AppendLine(" and educationid like '%" + txt_cmisno.Text.Trim() + "%'");
            }
            if (!string.IsNullOrEmpty(cbb_School.Text))
            {
                sqlWhere.AppendLine( " and school like '%" + cbb_School.Text + "%'");
            }

            if (!string.IsNullOrEmpty(cbb_grade.Text))
            {
                sqlWhere.AppendLine( " and grade like '%" + cbb_grade.Text + "%'");
            }

            if (!string.IsNullOrEmpty(this.cbb_class.Text))
            {
                sqlWhere.AppendLine( " and classes like '%" + cbb_class.Text + "%'");
            }

            if (!string.IsNullOrEmpty(this.txt_name.Text.Trim()))
            {
                sqlWhere.AppendLine( " and name like '%" + txt_name.Text.Trim() + "%'");
            }
            return sqlWhere.ToString();
        }
        private void cbb_School_SelectedValueChanged(object sender, EventArgs e)
        {
            initcbb_grade();
            initcbb_class();
            initGridView(string.Empty);
        }

        private void cbb_grade_SelectedValueChanged(object sender, EventArgs e)
        {
            initcbb_class();
            initGridView(string.Empty);
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex= e.RowIndex;
            if (rowIndex<0)
            {
                dataGrid.Rows[0].Selected = true;
                rowIndex = 0;
            }
            DataGridKey = Convert.ToString(dataGrid.Rows[rowIndex].Cells[0].Value);
        }

        private void txt_cmisno_TextChanged(object sender, EventArgs e)
        {
            string eduID = txt_cmisno.Text;
            if (txt_cmisno.Text.Length > 8)
            {
                txt_cmisno.Text = txt_cmisno.Text.Substring(txt_cmisno.Text.Length - 8);
            }
            if (txt_cmisno.Text.Length == 8)
            {
                this.initGridView(string.Empty);
            }
            if (txt_cmisno.Text.Length >= 7)
            {
                txt_cmisno.Text = txt_cmisno.Text.Substring(txt_cmisno.Text.Length - 7);
                this.initGridView(string.Empty);
            }
        }

        private void cbb_class_TextChanged(object sender, EventArgs e)
        {
            this.initGridView(string.Empty);
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            this.initGridView(string.Empty);
        }

        private void txt_KeyWord_TextChanged(object sender, EventArgs e)
        {
            this.initGridView(string.Empty);
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            //OperationLog.Debug("keyDown开始运行："+ txt_cmisno.Text);
            //if (txt_cmisno.Text.Length>8)
            //{

            //}
            //this.initGridView(string.Empty);
            //OperationLog.Debug("keyDown开始运行结束。");
        }
    }
}
