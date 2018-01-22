using System;
using System.Reflection;
using FW.Utility;

namespace FW.Bussiness
{
    public class BusinessManager
    {
        static IBusinessConfigProvider proivder = null;
        static BusinessManager()
        {
            proivder=
                ResourcesFactory.CreateFactory("FW.Bussiness",
                "FW.Bussiness.BusinessXMLConfigProvider,FW.Bussiness") as IBusinessConfigProvider;
            
        }
        //static Assembly businessAssembly = null;
        public static IResponse Execute(IRequest request)
        {
            IBusinessLogic logic = ResourcesFactory.CreateFactory("Com.cn.Business",
                        "Com.cn.Business.DoAction,Com.cn.Business") as IBusinessLogic;
            try
            {
                string typeName = proivder.GetTypeName(request.FunctionId, request.Action);
                if (!string.IsNullOrEmpty(typeName))
                {
                    object objFactory = 
                        ResourcesFactory.CreateFactory(Assembly.GetExecutingAssembly().FullName,typeName);
                    if (null != objFactory)
                    {
                        logic = objFactory as IBusinessLogic;
                    }
                }
            }
            catch (Exception)
            {
            }
            if (null==logic)
            {
                return new Response();
            }
            if (ActionStatue.Query == request.ActionStatue)
            {
                return logic.ExecuteQuery(request);
            }
            else
            {
                return logic.Execute(request);
            }

        }

        ////ADD丂BY丂LJS丂2008/11/07丂START
        ///// <summary>
        ///// Tracation傪偮偗側偄懳墳
        ///// </summary>
        ///// <param name="blnTras">tracation奐巒僼儔僌</param>
        ///// <param name="request">儕僋僄僗僩</param>
        ///// <returns>IResponse</returns>
        //public static IResponse Execute(bool blnTras, IRequest request)
        //{

        //    string typeName = proivder.GetTypeName(request.FunctionId, request.Action);

        //    Type type = Type.GetType(typeName);

        //    Interface.Business.IBusinessLogic logic = (Interface.Business.IBusinessLogic)Activator.CreateInstance(type);
        //    if (request.IsQuery)
        //    {
        //        return logic.ExecuteQuery(request);
        //    }
        //    else
        //    {
        //        return logic.Execute(blnTras, request);
        //    }

        //}
    }
}
