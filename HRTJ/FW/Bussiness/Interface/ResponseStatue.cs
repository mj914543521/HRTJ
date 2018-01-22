using System;

namespace FW.Bussiness
{
    [Serializable]
    public enum ResponseStatue
    {
        /// <summary>
        /// 
        /// </summary>
        OK,
        /// <summary>
        /// 
        /// </summary>
        NG
    }

    [Serializable]
    public enum ActionStatue
    {
        Save,
        Update,
        Query,
        Delete,
    }
}
