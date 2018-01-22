using System;
using System.Reflection;

namespace FW.Utility
{
    public sealed class ReflectHelper
    {
        /// <summary>
        /// 僞僀僾柤傪巜掕偟偰 System.Type 傪庢摼偡傞丅庢摼偱偒側偄応崌偼 Null 傪栠傞丅
        /// </summary>
        /// <param name="typeName">僞僀僾偺姰慡尷掕柤</param>
        /// <returns></returns>
        public static Type FindType(string typeName)
        {
            return ReflectHelper.FindType(null, typeName);
        }

        /// <summary>
        /// 傾僙儞僽儕偺姰慡尷掕柤偲僞僀僾柤傪巜掕偟偰 System.Type 傪庢摼偡傞丅
        /// 庢摼偱偒側偄応崌偼 Null 傪栠傞丅
        /// </summary>
        /// <param name="assemblyName">傾僙儞僽儕柤偺姰慡尷掕柤</param>
        /// <param name="typeName">僞僀僾偺姰慡尷掕柤</param>
        /// <returns>巜掕偝傟偨宆傪昞偡 System.Type 僆僽僕僃僋僩</returns>
        public static Type FindType(string assemblyName, string typeName)
        {
            if (string.IsNullOrEmpty(assemblyName))
                assemblyName = Assembly.GetExecutingAssembly().FullName;

            try
            {
                // 婛懚偺僞僀僾傪儘乕僪偡傞丅
                Type type = Type.GetType(typeName);

                if (type == null)
                {
                    // 傾僙儞僽儕傪撉傒崬傓丅
                    Assembly assembly = Assembly.Load(assemblyName);
                    if (assembly != null)
                    {
                        type = assembly.GetType(typeName);
                    }
                }

                return type;
            }
            catch (Exception ex)
            {
                // ...
            }

            return null;
        }
    }
}
