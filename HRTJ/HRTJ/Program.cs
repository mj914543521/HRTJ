using System;
using System.Threading;
using System.Windows.Forms;
using Com.cn.SncData;
using Com.cn.Log;

namespace HRTJ
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            SncData snc = new SncData();
            snc.SncUserClientData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HRTJ.TJXX());
        }
    }
}
