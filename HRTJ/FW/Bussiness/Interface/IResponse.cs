using System.Collections;
using System.Data;

namespace FW.Bussiness
{
   public interface IResponse
    {
        ResponseStatue Statue
        {
            get;
            set;
        }

        string Message
        {
            get;
            set;
        }

        DataSet ResultSet
        {
            get;
            set;
        }

        DataTable ResultTable
        {
            get;
            set;
        }

        object Value
        {
            get;
            set;
        }
    }
}
