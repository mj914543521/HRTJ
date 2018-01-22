using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using log4net.Layout;
using log4net.Layout.Pattern;

namespace Com.cn.Log
{
    public class ReflectionLayout : PatternLayout
    {

        public ReflectionLayout()
        {
            this.AddConverter("property", typeof(ReflectionPatternConverter));
        }

    }

    public class ReflectionPatternConverter : PatternLayoutConverter
    {

        protected override void Convert(
            System.IO.TextWriter writer,
            log4net.Core.LoggingEvent loggingEvent)
        {

            if (Option != null)
            {
                WriteObject(
                    writer,
                    loggingEvent.Repository,
                    LookupProperty(Option,
                    loggingEvent));

            }
            else
            {
                WriteDictionary(
                    writer,
                    loggingEvent.Repository,
                    loggingEvent.GetProperties());
            }

        }

        /// <summary>
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        private object LookupProperty(string property, log4net.Core.LoggingEvent loggingEvent)
        {

            object propertyValue = string.Empty;

            PropertyInfo propertyInfo = loggingEvent.MessageObject.GetType().GetProperty(property);
            if (propertyInfo != null)
                propertyValue = propertyInfo.GetValue(loggingEvent.MessageObject, null);

            return propertyValue;

        }
    }

    public class LogContent
    {
        public LogContent(string id, string userId, string ipaddress, string message)
        {
            _id = id;
            _userId = userId;
            _ipaddress = ipaddress;
            _message = message;
        }


        string _id;
        /// <summary>
        /// 画面ID
        /// </summary>
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        string _userId;
        /// <summary>
        /// ユーザID
        /// </summary>
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        string _ipaddress;
        /// <summary>
        /// IPアドレス
        /// </summary>
        public string IpAddress
        {
            get { return _ipaddress; }
            set { _ipaddress = value; }
        }

        string _message;
        /// <summary>
        /// メッセージ内容
        /// </summary>
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

    }
}
