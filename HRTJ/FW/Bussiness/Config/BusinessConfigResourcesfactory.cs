using FW.Utility;


namespace FW.Bussiness.Config
{
    class BusinessConfigResourcesfactory : ResourcesFactory
    {
        public override Resources CreateResources(string resource)
        {
            return new BusinessConfigResources(resource);
        }
    }
}
