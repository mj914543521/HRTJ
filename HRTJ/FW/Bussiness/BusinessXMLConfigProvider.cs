using FW.Bussiness.Config;
using System;

namespace FW.Bussiness
{
    public class BusinessXMLConfigProvider : IBusinessConfigProvider
    {
        public string GetTypeName(string functionId, string action)
        {
            string typeName = BusinessConfig.GetTypeName(functionId, action);
            return typeName;
        }

        
    }
}
