using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace FW.Config
{
    public static class XmlHelp
    {
        private static Hashtable objCache = new Hashtable();
        private static object syncRoot = new Object();


        /// <summary>
        /// 获得xml文件中指定节点的节点数据
        /// </summary>
        /// <param name="path"></param>
        /// <param name="nodeName"></param>
        /// <returns></returns>
        public static XmlNode GetNodeInfoByNodeName(string path, string nodeName)
        {
            XmlNode node = null;
            try
            {
                if (objCache != null && objCache.Contains(path + "_" + nodeName))
                {
                    return (objCache[path + "_" + nodeName] as XmlNode);
                }
                lock (syncRoot)
                {
                    var xml = new XmlDocument();
                    xml.Load(path);
                    var root = xml.DocumentElement;

                    node = root.SelectSingleNode("//" + nodeName);
                }
                
                objCache[path + "_" + nodeName] = node;
            }
            catch (Exception er)
            {
                throw new Exception(er.ToString());
            }
            return node;
        }

        /// <summary>  
        /// 功能:读取指定节点的指定属性值     
        /// </summary>
        /// <param name="path"></param>
        /// <param name="strNode">节点名称</param>  
        /// <param name="strAttribute">此节点的属性</param>  
        /// <returns></returns>  
        public static string GetXmlNodeAttributeValue(string path, string strNode, string strAttribute)
        {
            var strReturn = "";
            try
            {
                var xml = new XmlDocument();
                xml.Load(path);
                //根据指定路径获取节点  
                var xmlNode = xml.SelectSingleNode(strNode);
                if (xmlNode != null)
                {
                    //获取节点的属性，并循环取出需要的属性值  
                    var xmlAttr = xmlNode.Attributes;
                    if (xmlAttr == null) return strReturn;
                    for (var i = 0; i < xmlAttr.Count; i++)
                    {
                        if (xmlAttr.Item(i).Name != strAttribute) continue;
                        strReturn = xmlAttr.Item(i).Value;
                        break;
                    }
                }
            }
            catch (XmlException xmle)
            {
                throw new Exception(xmle.Message);
            }
            return strReturn;
        }
    }
}
