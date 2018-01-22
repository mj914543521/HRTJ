using FW.Config;
using FW.Utility;
using System.Reflection;

namespace FW.Bussiness.Config
{
    public class BusinessConfig
    {
        private static BusinessConfigResources logics = null;

        /// <summary>
        /// 
        /// </summary>
        static BusinessConfig()
        {
            string logicConfig = "~/BusinessLogic.xml";
            string assemblyName = Assembly.GetExecutingAssembly().FullName;
            string typeName = typeof(BusinessConfigResourcesfactory).FullName;
            ResourcesFactory factory = ResourcesFactory.CreateFactory(assemblyName, typeName) as ResourcesFactory;
            logics = (BusinessConfigResources)factory.CreateResources(PathHelper.GetAbsolutePath(logicConfig));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageId"></param>
        /// <returns></returns>
        public static string GetTypeName(string functionid, string action)
        {
            if (string.IsNullOrEmpty(functionid))
            {
                return null;
            }
            if (string.IsNullOrEmpty(action))
            {
                return null;
            }
            System.Collections.Specialized.NameValueCollection col = (System.Collections.Specialized.NameValueCollection)logics.GetResource(functionid);
            if (col == null)
            {
                return null;
            }

            return col[action];
        }
    }
}
