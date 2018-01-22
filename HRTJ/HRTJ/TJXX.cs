using System;
using System.Data;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Com.cn.DB;
using Com.cn.HRWJDataSet;
using Com.cn.Log;
using Com.cn.SncData;
using FW.Config;
using HRTJ.Base;
using HRTJ.login;

namespace HRTJ
{
    public partial class TJXX : Form
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

        public static HRWJAccessDataSet.tb_userDataTable userDataTable = new HRWJAccessDataSet.tb_userDataTable();
        private static HRWJAccessDataSet.tb_officeDataTable _officeDataTable;
        public HRWJAccessDataSet.tb_officeDataTable officeDataTable
        {
            get
            {
                if (!(_officeDataTable != null && _officeDataTable.Rows.Count > 0))
                {
                    if (userDataTable != null && userDataTable.Rows.Count > 0)
                    {
                        string officeid = Convert.ToString(userDataTable.Rows[0][userDataTable.officeidColumn.ColumnName]);
                        if (!string.IsNullOrEmpty(officeid))
                        {
                            if (_officeDataTable == null)
                            {
                                _officeDataTable = new HRWJAccessDataSet.tb_officeDataTable();
                            }
                            DBSession.Query("select * from tb_office where id =" + officeid, _officeDataTable);
                        }
                    }
                }
                return _officeDataTable;
            }

        }
        public string DataGridKey
        {
            get { return this.userControl_TJXX1.DataGridKey; }
        }



        public TJXX()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 录入按钮操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {
            HRWJAccessDataSet.tb_studentexam_ClientRow row = UserControl_TJXX.studentexamRow;
            if (row == null)
            {
                return;
            }
            string url = string.Empty;

            if (null != this.officeDataTable && this.officeDataTable.Rows.Count > 0)
            {
                url = Convert.ToString(this.officeDataTable.Rows[0][this.officeDataTable.urlColumn.ColumnName]);
            }

            Form frm = null;
            if (url.LastIndexOf("office_getMedicalOffice1") >=0)
            {
                frm = new Frm_NK1();
            }
            else if (url.LastIndexOf("office_getMedicalOffice2") >= 0)
            {
                frm = new Frm_NK2();
            }
            else if (url.LastIndexOf("office_getStomatologyOffice") >= 0)
            {
                frm = new Frm_KQK();
            }
            else if (url.LastIndexOf("office_getSurgeryOffice1") >= 0)
            {
                frm = new Frm_WK1();
            }
            else if (url.LastIndexOf("office_getSurgeryOffice2") >= 0)
            {
                frm = new Frm_WK2();
            }
            else if (url.LastIndexOf("office_getLaboratoryOffice") >= 0)
            {
                frm = new Frm_JYK();
            }
            else if (url.LastIndexOf("office_getEyeOffice1") >= 0)
            {
                frm = new Frm_YK1();
            }
            else if (url.LastIndexOf("office_getEyeOffice2") >= 0)
            {
                frm = new Frm_YK2();
            }
            if (null != frm)
            {
                frm.ShowDialog();
            }
            this.userControl_TJXX1.initGridView("");
            //ThreadStart method = new ThreadStart(sncData);
            //Thread thead = new Thread(method);
            //thead.Start();
            userControl_TJXX1.txt_cmisno.Focus();

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            try
            {

                ExportExcel();
                MessageBox.Show("导出成功!");
            }
            catch (Exception ex)
            {
                OperationLog.Error("导出失败！", ex);
            }
        }

        private void SysData_Click(object sender, EventArgs e)
        {
            sncData();
            this.userControl_TJXX1.initComBox();
            MessageBox.Show("数据同步成功！", "提示") ;
        }

        private void TJXX_Load(object sender, EventArgs e)
        {
            // ConfrimForm();
            userControl_TJXX1.txt_cmisno.Focus();
        }

        private void ConfrimForm()
        {
            if (TJXX.userDataTable != null && TJXX.userDataTable.Rows.Count > 0)
            {
            }
            else
            {
                userControl_TJXX1.initGridView(" and 1=2 ");
                Frm_login frm = new Frm_login();
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    // sncData();
                    Application.Exit();
                }
                else
                {
                    ConfrimForm();
                    userControl_TJXX1.initComBox();
                    // userControl_TJXX1.initGridView(string.Empty);
                }
            }
        }

        #region 同步数据
        public void sncData()
        {
            try
            {
                SncData sncData = new SncData();
                sncData.UpStudentexamData();
                sncData.DownDataStudentexam();
            }
            catch (Exception ex)
            {
                OperationLog.Error("上传数据出错", ex);
            }
        }
        #endregion
        #region 导出Excel
        protected void ExportExcel()
        {
            string title = "怀柔区中小学健康信息网络化体检系统";
            title = ConfigManager.GetAppConfig("studentexamExcelTitle");
            string studentexamExcelColumns = ConfigManager.GetAppConfig("studentexamExcelColumns");
            if (string.IsNullOrEmpty(studentexamExcelColumns))
            {
                studentexamExcelColumns = "*";
            }

            StringBuilder sql = new StringBuilder();
            sql.AppendLine(" select ");
            sql.AppendLine("        " + studentexamExcelColumns);
            sql.AppendLine("   from tb_studentexam");
            sql.AppendLine("  where ");
            sql.AppendLine("        1=1 ");
            sql.AppendLine(userControl_TJXX1.GridViewWhere());
            DataTable table = new DataTable();
            DBSession.Query(sql.ToString(), table);
            ExportExcel(table, title);
        }

        protected void ExportExcel(DataTable table, string title)
        {
            if (table == null || table.Rows.Count < 1) return;

            string saveFileName = "";
            //   bool fileSaved=false;
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xls";
            saveDialog.Filter = "Excel 文件|*.xls";
            saveDialog.FileName = title;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return; //被点了取消
            if (File.Exists(saveFileName))
            {
                try
                {
                    File.Delete(saveFileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("该文件读写权限不足，不能替换", "错误");
                }
                
            }


            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            object missing = System.Reflection.Missing.Value;


            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，可能您的机子未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook
                = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet
                = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1
            Microsoft.Office.Interop.Excel.Range range;


            string oldCaption = title;
            long totalCount = table.Rows.Count;
            long rowRead = 0;
            float percent = 0;

            worksheet.Cells[1, 1] = title;

            ((Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, 1]).HorizontalAlignment
                = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //写入字段
            for (int i = 0; i < table.Columns.Count; i++)
            {
                worksheet.Cells[2, i + 1] = table.Columns[i].ColumnName;
                range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[2, i + 1];
                range.Interior.ColorIndex = 15;
                range.Font.Bold = true;
                range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            }
            //写入数值
            // Caption.Visible = true;
            for (int r = 0; r < table.Rows.Count; r++)
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[r + 3, i + 1];
                    range.NumberFormat = "@";
                    string dataTypeName = table.Columns[i].DataType.Name.ToLower();
                    if (dataTypeName.Contains("date") || dataTypeName.Contains("time"))
                    {
                        DateTime time = DateTime.MinValue;
                        if (DateTime.TryParse(Convert.ToString(table.Rows[r][i]), out time))
                        {
                            worksheet.Cells[r + 3, i + 1] = time.ToString();
                        }
                    }
                    else
                    {
                        worksheet.Cells[r + 3, i + 1] = Convert.ToString(table.Rows[r][i]);
                    }
                }
            }

            //this.Caption.Visible = false;
            //this.Caption.Text = oldCaption;
            #region 表头合并
            //获取需要合并的单元格的范围
            Microsoft.Office.Interop.Excel.Range rangeProgram
                = worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[1, table.Columns.Count]);
            rangeProgram.Application.DisplayAlerts = false;
            rangeProgram.Merge(missing);
            rangeProgram.Application.DisplayAlerts = true;
            rangeProgram.Font.Bold = true;
            #endregion

            range = worksheet.get_Range(worksheet.Cells[2, 1], worksheet.Cells[table.Rows.Count + 2, table.Columns.Count]);
            range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous,
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin,
                Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic,
                null);
            range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            range.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideHorizontal].ColorIndex
                = Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic;
            range.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideHorizontal].LineStyle
                = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            range.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideHorizontal].Weight
                = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            if (table.Columns.Count > 1)
            {
                range.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideVertical].ColorIndex
                    = Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic;
            }

            worksheet.SaveAs(saveFileName, missing, missing, missing, missing, missing, missing, missing, missing);
            workbook.Close(missing, missing, missing);
            xlApp.Quit();
        }

        #endregion

        private void tsb_xxxx_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_XXXX();
            frm.ShowDialog();
        }

    }
}
