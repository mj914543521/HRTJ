using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRTJ.Base
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
//            SELECT top 100 *
//FROM tb_studentexam_Client AS tb_studentexam_Client_1
//where name like '%刘%'
//and ID not in (select top 300 ID from tb_studentexam_Client where name like '%刘%' order by school,grade,classes)

//order by school,grade,classes

        }
    }
}
