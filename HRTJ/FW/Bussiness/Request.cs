using System;
using System.Collections;

namespace FW.Bussiness
{
    public class Request : IRequest
    {
        private string _QueryString;

        public string QueryString
        {
            get { return _QueryString; }
            set { _QueryString = value; }
        }

        private FW.EntityObj.EntityObj _EntityObj;
        public FW.EntityObj.EntityObj EntityObj
        {
            get
            {
                return _EntityObj;
            }
            set
            {
                _EntityObj = value;
            }
        }


        private string _action;
        public string Action
        {
            get
            {
                return _action;
            }
            set
            {
                _action = value;
            }
        }


        private string _FunctionId;
        public string FunctionId
        {
            get
            {
                return _FunctionId;
            }
            set
            {
                _FunctionId = value;
            }
        }

        private ActionStatue _ActionStatue;
        public ActionStatue ActionStatue
        {
            get
            {
                return _ActionStatue;
            }
            set
            {
                _ActionStatue = value;
            }
        }
        private Hashtable ht = new Hashtable();

        public void Add(object key, object value)
        {
            ht.Add(key, value);
        }

        public void Clear()
        {
            ht.Clear();
        }

        public bool Contains(object key)
        {
            return ht.Contains(key);
        }

        public System.Collections.IDictionaryEnumerator GetEnumerator()
        {
            return ht.GetEnumerator();
        }

        public bool IsFixedSize
        {
            get
            {
                return ht.IsFixedSize;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return ht.IsReadOnly;
            }
        }

        public System.Collections.ICollection Keys
        {
            get
            {
                return ht.Keys;
            }
        }

        public void Remove(object key)
        {
            ht.Remove(key);
        }

        public System.Collections.ICollection Values
        {
            get
            {
                return ht.Values;
            }
        }

        public object this[object key]
        {
            get
            {
                return ht[key];
            }
            set
            {
                ht[key] = value;
            }
        }

        public void CopyTo(Array array, int index)
        {
            ht.CopyTo(array, index);
        }

        public int Count
        {
            get
            {
                return ht.Count;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return ht.IsSynchronized;
            }
        }

        public object SyncRoot
        {
            get
            {
                return ht.SyncRoot;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ht.GetEnumerator();
        }
    }
}
