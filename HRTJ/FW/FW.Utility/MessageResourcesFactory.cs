
namespace FW.Utility
{
    public class MessageResourcesFactory : ResourcesFactory
    {
        /// <summary>
        /// 巜掕偟偨儕僜乕僗柤偵傛偭偰丄儊僢僙乕僕儕僜乕僗僆僽僕僃僋僩傪惗惉偡傞丅
        /// </summary>
        /// <param name="config">儕僜乕僗柤</param>
        /// <returns>儊僢僙乕僕儕僜乕僗僆僽僕僃僋僩</returns>
        public override Resources CreateResources(string config)
        {
            return new MessageResources(config);
        }
    }
}
