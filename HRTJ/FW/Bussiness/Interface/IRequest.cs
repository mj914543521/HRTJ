
using System.Collections;

namespace FW.Bussiness
{
    public interface IRequest : IDictionary
    {
        FW.EntityObj.EntityObj EntityObj { get; set; }
        string QueryString { get; set; }
        string FunctionId { get; set; }
        string Action{ get; set; }
        ActionStatue ActionStatue { get; set; }
    }
}
