
namespace FW.Bussiness
{
    interface IBusinessLogic
    {
        /// <summary>
        /// 専嶕宯偺僐乕儖僀儞僞僼僃乕僗
        /// </summary>
        /// <param name="request">惪媮僷儔儊乕僞</param>
        /// <returns>墳摎寢壥</returns>
        IResponse ExecuteQuery(IRequest request);

        /// <summary>
        /// 峏怴宯偺僐乕儖僀儞僞僼僃乕僗
        /// </summary>
        /// <param name="request">惪媮僷儔儊乕僞</param>
        /// <returns>墳摎寢壥</returns>
        IResponse Execute(IRequest request);
    }
}
