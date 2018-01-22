using System;

using Com.cn.HRWJDataSet;

namespace HRTJ.Base
{
    public partial class UserControlInfor : Control
    {
        public UserControlInfor()
        {
            InitializeComponent();
        }

        public override void Init(HRWJAccessDataSet.tb_studentexam_ClientRow row)
        {
            base.Init(row);
            this.lbl_Class.Text = Convert.ToString(row[studentexamDB.classesColumn.ColumnName]);
            this.lbl_cmisno.Text = Convert.ToString(row[studentexamDB.educationidColumn.ColumnName]);
            this.lbl_grade.Text = Convert.ToString(row[studentexamDB.gradeColumn.ColumnName]);
            this.lbl_Name.Text = Convert.ToString(row[studentexamDB.nameColumn.ColumnName]);
            this.lbl_School.Text = Convert.ToString(row[studentexamDB.schoolColumn.ColumnName]);
            this.lbl_Sex.Text = Convert.ToString(row[studentexamDB.sexColumn.ColumnName]);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ID = UserControl_TJXX._DataGridKey;
        }   
    }
}
