using System;
using System.Xml;

namespace FW.Utility
{
    public class MessageResources : Resources
    {
        /// <summary>
        /// 怴偟偄僀儞僗僞儞僗傪弶婜壔偡傞丅
        /// </summary>
        /// <param name="config">儊僢僙乕僕儕僜乕僗僼傽僀儖</param>
        public MessageResources(string config)
            : base(config)
        {
        }

        /// <summary>
        /// 怴偟偄僀儞僗僞儞僗傪弶婜壔偡傞丅
        /// </summary>
        /// <param name="config">儊僢僙乕僕儕僜乕僗僼傽僀儖</param>
        /// <param name="isShowId">儕僜乕僗ID傪昞帵偡傞偐偳偆偐僼儔僌</param>
        public MessageResources(string config, bool isShowId)
            : base(config, isShowId)
        {
        }


        /// <summary>
        /// 儕僜乕僗ID傪巜掕偟偰儕僜乕僗撪梕傪庢摼偡傞丅
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="resourceId">儕僜乕僗ID</param>
        /// <param name="args">奺僷儔儊乕僞抣</param>
        /// <returns>儕僜乕僗撪梕</returns>
        protected override object PostGetResource(object resource, string resourceId, params object[] args)
        {
            string content = (string)resource;
            if (content == null)
            {
                content = string.Empty;
            }
            else
            {
                if (args != null && args.Length > 0)
                    content = string.Format(content, args);
            }

            if (_isShowId)
                return string.Format(DEFAULT_FORMAT, resourceId, content);
            else
                return content;
        }

        /// <summary>
        /// 儕僜乕僗撪梕傪弶婜壔偡傞丅
        /// </summary>
        protected override void InitResources()
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader(this._config))
                {
                    XmlDocument document = new XmlDocument();
                    document.Load(reader);
                    XmlNodeList list = document.SelectNodes("messages/message");

                    foreach (XmlNode node in list)
                    {
                        try
                        {
                            string id = node.Attributes["id"].Value;
                            string content = node.Attributes["content"].Value;
                            if (id != null)
                            {
                                _resourceIds[id] = content;
                            }
                        }
                        catch
                        {
                            continue;
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
