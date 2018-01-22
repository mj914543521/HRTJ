using Com.cn.DBSession;
using NHibernate;
using System;

namespace FW.Bussiness
{
    public abstract class BusinessLogic : IBusinessLogic
    {
        public IResponse ExecuteQuery(IRequest request)
        {
            return MainProcess(null, false, request);
        }

        public IResponse Execute(IRequest request)
        {
            return MainProcess(null, true, request);
        }


        public IResponse Execute(ISession useAccesser, IRequest request)
        {
            return MainProcess(useAccesser, true, request);
        }

        protected virtual void PreProcess(ISession accesser, IRequest request)
        {

        }
        protected abstract void DoProcess(ISession accesser, IRequest request, IResponse response);
        protected virtual void PostProcess(ISession accesser, IRequest request, IResponse response)
        {

        }
        private IResponse MainProcess(ISession useAccesser, bool hasTransaction, IRequest request)
        {
            bool isRootTransaction = false;
            ITransaction vTransaction = null;
            if (useAccesser == null)
            {
                //DB傾僋僙僗懳徾傪庢摼
                try
                {
                    useAccesser = DBSession.SessionLoad();
                    isRootTransaction = true;
                }
                catch (Exception ex)
                {
                    // Exceptions.Handlers.ExceptionHandler.HandleException(ex);
                }
            }
            else
            {

            }
            //栠傝懳徾
            IResponse response = new Response();
            response.Statue = ResponseStatue.OK;
            try
            {
                //Transaction偑昁梫偱偁傟偽奩摉accesser偱Transaction傪婲摦
                if (hasTransaction && isRootTransaction)
                {
                    vTransaction = useAccesser.BeginTransaction();
                    vTransaction.Begin();
                }
                PreProcess(useAccesser, request);
                DoProcess(useAccesser, request, response);
                //*************************************************************
                // 捛壛 2008/01/31 搨
                //if (useAccesser.LIMIT_OVER_FLG)
                //{
                //    MessageObject message = new MessageObject("E_COM_169", new String[] { useAccesser.LimitRecordCount.ToString(), useAccesser.RecordNum.ToString(), useAccesser.LimitRecordCount.ToString() });

                //    MessagePipeManager.GetMessagePipe().Push(message);
                //}
                //**************************************************************

                if (hasTransaction && isRootTransaction)
                {
                    vTransaction.Commit();
                }
                PostProcess(useAccesser, request, response);
            }
            catch (Exception ex)
            {
                if (vTransaction !=null)
                {
                    vTransaction.Rollback();    
                }
                response.Statue = ResponseStatue.NG;
                response.Message = ex.Message;
                // HandingException(ex);
            }
            finally
            {
                if (isRootTransaction)
                {
                    useAccesser.Close();
                    useAccesser = null;
                }
                GC.Collect();
            }
            return response;
        }
    }
}
