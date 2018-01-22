
namespace FW.Bussiness
{
    public class Response : IResponse
    {
        private ResponseStatue _Statue;
        public ResponseStatue Statue
        {
            get
            {
                return _Statue;
            }
            set
            {
                _Statue = value;
            }
        }

        private string _Message;
        public string Message
        {
            get
            {
                return _Message;
            }
            set
            {
                _Message = value;
            }
        }

        private System.Data.DataSet _ResultSet;
        public System.Data.DataSet ResultSet
        {
            get
            {
                return _ResultSet;
            }
            set
            {
                _ResultSet = value;
            }
        }

        private System.Data.DataTable _ResultTable;
        public System.Data.DataTable ResultTable
        {
            get
            {
                return _ResultTable;
            }
            set
            {
                _ResultTable = value;
            }
        }

        private object _Value;
        public object Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
            }
        }
    }
}
