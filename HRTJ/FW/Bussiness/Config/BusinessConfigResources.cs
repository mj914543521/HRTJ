using FW.Utility;
using System;
using System.Xml;

namespace FW.Bussiness.Config
{
    public class BusinessConfigResources : Resources
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        public BusinessConfigResources(string config)
            : base(config, false)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void InitResources()
        {

            try
            {
                using (XmlTextReader reader = new XmlTextReader(this._config))
                {
                    XmlDocument document = new XmlDocument();
                    document.Load(reader);
                    XmlNodeList list = document.SelectNodes("BusinessLogics/functionid");


                    foreach (XmlNode node in list)
                    {
                        string id = node.Attributes["id"].Value;
                        XmlNodeList logics = node.SelectNodes("businesslogic");

                        System.Collections.Specialized.NameValueCollection col = new System.Collections.Specialized.NameValueCollection();

                        foreach (XmlNode logic in logics)
                        {
                            string action = logic.Attributes["action"].Value;
                            if (logic.Attributes["type"] != null)
                            {
                                string type = logic.Attributes["type"].Value;
                                col[action] = type;

                            }
                        }
                        if (col.Count != 0)
                        {
                            _resourceIds[id] = col;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }    
}
