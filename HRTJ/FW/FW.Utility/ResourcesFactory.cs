using System;
using System.Reflection;

namespace FW.Utility
{
    public abstract class ResourcesFactory
    {
        /// <summary>
        /// 僨僼僅儖岺応僋儔僗偺傾僙儞僽儕偺姰慡尷掕柤傪掕媊偡傞丅
        /// </summary>
        private static readonly string DEFAULT_ASSEMBLY_NAME = Assembly.GetExecutingAssembly().FullName;

        /// <summary>
        /// 僨僼僅儖岺応僋儔僗姰慡尷掕柤傪掕媊偡傞丅
        /// </summary>
        private static readonly string DEFAULT_TYPE_NAME = typeof(MessageResourcesFactory).FullName;

        /// <summary>
        /// 嬶懱揑側岺応僆僽僕僃僋僩傪惗惉偡傞丅惗惉偱偒側偄応崌偼 Null 傪栠傞丅
        /// </summary>
        /// <returns>嬶懱揑側岺応僆僽僕僃僋僩</returns>
        public static object CreateFactory()
        {
            return ResourcesFactory.CreateFactory(null, null);
        }

        /// <summary>
        /// 嬶懱揑側岺応僆僽僕僃僋僩傪惗惉偡傞丅惗惉偱偒側偄応崌偼 Null 傪栠傞丅
        /// </summary>
        /// <param name="typeName">僞僀僾偺姰慡尷掕柤</param>
        /// <returns>嬶懱揑側岺応僆僽僕僃僋僩</returns>
        public static object CreateFactory(string typeName)
        {
            return ResourcesFactory.CreateFactory(null, typeName);
        }

        /// <summary>
        /// 嬶懱揑側岺応僆僽僕僃僋僩傪惗惉偡傞丅惗惉偱偒側偄応崌偼 Null 傪栠傞丅
        /// </summary>
        /// <param name="assemblyName">傾僙儞僽儕偺姰慡尷掕柤</param>
        /// <param name="typeName">僞僀僾偺姰慡尷掕柤</param>
        /// <returns>嬶懱揑側岺応僆僽僕僃僋僩</returns>
        public static object CreateFactory(string assemblyName, string typeName)
        {
            try
            {
                if (string.IsNullOrEmpty(assemblyName))
                    assemblyName = DEFAULT_ASSEMBLY_NAME;
                if (string.IsNullOrEmpty(typeName))
                    typeName = DEFAULT_TYPE_NAME;

                Type type = ReflectHelper.FindType(assemblyName, typeName);

                if (type != null)
                {
                    object factory = Activator.CreateInstance(type);
                    return factory;
                }
            }
            catch (Exception ex)
            {
                //string message = string.Format(
                //    InnerConstants.INIT_TYPE_ERR_MSG, assemblyName, typeName);
                //SystemLog.Error(message, ex);

            }

            return null;
        }

        /// <summary>
        /// 巜掕偟偨儕僜乕僗柤偵傛偭偰丄儕僜乕僗僆僽僕僃僋僩傪惗惉偡傞丅
        /// </summary>
        /// <param name="resource">儕僜乕僗</param>
        /// <returns>儕僜乕僗傪帩偰偄傞僆僽僕僃僋僩</returns>
        public abstract Resources CreateResources(string resource);
    }
}
