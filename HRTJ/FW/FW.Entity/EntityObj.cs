using System;

namespace FW.EntityObj
{
    public class EntityObj
    {
        public virtual int ID { get; set; }
        public virtual int CreateUser { get; set; }
        public virtual DateTime CreateTime { get; set; }
        public virtual int UpdateUser { get; set; }
        public virtual DateTime UpdateTime { get; set; }
    }
}
