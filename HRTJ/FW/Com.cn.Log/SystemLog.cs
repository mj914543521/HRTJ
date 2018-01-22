using System;
using System.Collections.Generic;
using System.Text;
using log4net;

namespace Com.cn.Log
{
    public sealed class SystemLog
    {
        #region 曄悢傪掕媊偡傞丅
        /// <summary>
        /// 儘僌婰榐僆僽僕僃僋僩傪掕媊偡傞丅
        /// </summary>
        private readonly ILog _log = null;

        /// <summary>
        /// 僨僶僢僋儘僌柤傪掕媊偡傞丅
        /// </summary>
        private const string DEBUG_LOG_NAME = "Log.System";

        /// <summary>
        /// 僨僶僢僋儘僌傪掕媊偡傞丅
        /// </summary>
        private static SystemLog _instance = new SystemLog(DEBUG_LOG_NAME);
        #endregion

        #region 僐儞僗僩儔僋僞傪掕媊偡傞丅
        /// <summary>
        /// 怴偟偄僀儞僗僞儞僗傪弶婜壔偡傞丅
        /// </summary>
        /// <param name="name">儘僌柤</param>
        private SystemLog(string name)
        {
            _log = LoggingManager.GetLogger(name);
        }
        #endregion

        #region 僨僶僢僌儘僌傪婰榐偡傞丅
        /// <summary>
        /// 僨僶僢僌儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕僆僽僕僃僋僩</param>
        public static void Debug(object message)
        {
            try
            {
                if (_instance._log.IsDebugEnabled)
                    _instance._log.Debug(message);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }

        /// <summary>
        /// 僨僶僢僌儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕僆僽僕僃僋僩</param>
        /// <param name="ex">椺奜僕僆僽僕僃僋僩</param>
        public static void Debug(object message, Exception ex)
        {
            try
            {
                if (_instance._log.IsDebugEnabled)
                    _instance._log.Debug(message, ex);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }

        /// <summary>
        /// 僨僶僢僌儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕</param>
        public static void Debug(string message)
        {
            try
            {
                if (_instance._log.IsDebugEnabled)
                    _instance._log.Debug(message);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }

        /// <summary>
        /// 僨僶僢僌儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕</param>
        /// <param name="ex">椺奜僕僆僽僕僃僋僩</param>
        public static void Debug(string message, Exception ex)
        {
            try
            {
                if (_instance._log.IsDebugEnabled)
                    _instance._log.Debug(message, ex);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }
        #endregion

        #region 塣梡儘僌傪婰榐偡傞丅
        /// <summary>
        /// 塣梡儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕僆僽僕僃僋僩</param>
        public static void Info(object message)
        {
            try
            {
                if (_instance._log.IsInfoEnabled)
                    _instance._log.Info(message);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }

        /// <summary>
        /// 塣梡儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕僆僽僕僃僋僩</param>
        /// <param name="ex">椺奜僕僆僽僕僃僋僩</param>
        public static void Info(object message, Exception ex)
        {
            try
            {
                if (_instance._log.IsInfoEnabled)
                    _instance._log.Info(message, ex);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }

        /// <summary>
        /// 塣梡儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕</param>
        public static void Info(string message)
        {
            try
            {
                if (_instance._log.IsInfoEnabled)
                    _instance._log.Info(message);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }

        /// <summary>
        /// 塣梡儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕</param>
        /// <param name="ex">椺奜僕僆僽僕僃僋僩</param>
        public static void Info(string message, Exception ex)
        {
            try
            {
                if (_instance._log.IsInfoEnabled)
                    _instance._log.Info(message, ex);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }
        #endregion

        #region 寈崘儘僌傪婰榐偡傞丅
        /// <summary>
        /// 寈崘儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕僆僽僕僃僋僩</param>
        public static void Warn(object message)
        {
            try
            {
                if (_instance._log.IsWarnEnabled)
                    _instance._log.Warn(message);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }

        /// <summary>
        /// 寈崘儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕僆僽僕僃僋僩</param>
        /// <param name="ex">椺奜僕僆僽僕僃僋僩</param>
        public static void Warn(object message, Exception ex)
        {
            try
            {
                if (_instance._log.IsWarnEnabled)
                    _instance._log.Warn(message, ex);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }

        /// <summary>
        /// 寈崘儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕</param>
        public static void Warn(string message)
        {
            try
            {
                if (_instance._log.IsWarnEnabled)
                    _instance._log.Warn(message);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }

        /// <summary>
        /// 寈崘儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕</param>
        /// <param name="ex">椺奜僕僆僽僕僃僋僩</param>
        public static void Warn(string message, Exception ex)
        {
            try
            {
                if (_instance._log.IsWarnEnabled)
                    _instance._log.Warn(message, ex);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }
        #endregion

        #region 僄儔乕儘僌傪婰榐偡傞丅
        /// <summary>
        /// 僄儔乕儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕僆僽僕僃僋僩</param>
        public static void Error(object message)
        {
            try
            {
                if (_instance._log.IsErrorEnabled)
                    _instance._log.Error(message);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }

        /// <summary>
        /// 僄儔乕儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕僆僽僕僃僋僩</param>
        /// <param name="ex">椺奜僕僆僽僕僃僋僩</param>
        public static void Error(object message, Exception ex)
        {
            try
            {
                if (_instance._log.IsErrorEnabled)
                    _instance._log.Error(message, ex);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }

        /// <summary>
        /// 僄儔乕儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕</param>
        public static void Error(string message)
        {
            try
            {
                if (_instance._log.IsErrorEnabled)
                    _instance._log.Error(message);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }

        /// <summary>
        /// 僄儔乕儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕</param>
        /// <param name="ex">椺奜僕僆僽僕僃僋僩</param>
        public static void Error(string message, Exception ex)
        {
            try
            {
                if (_instance._log.IsErrorEnabled)
                    _instance._log.Error(message, ex);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }
        #endregion

        #region 抳柦揑側儘僌傪婰榐偡傞丅
        /// <summary>
        /// 抳柦揑側儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕僆僽僕僃僋僩</param>
        public static void Fatal(object message)
        {
            try
            {
                if (_instance._log.IsFatalEnabled)
                    _instance._log.Fatal(message);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }

        /// <summary>
        /// 抳柦揑側儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕僆僽僕僃僋僩</param>
        /// <param name="ex">椺奜僕僆僽僕僃僋僩</param>
        public static void Fatal(object message, Exception ex)
        {
            try
            {
                if (_instance._log.IsFatalEnabled)
                    _instance._log.Fatal(message, ex);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }

        /// <summary>
        /// 抳柦揑側儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕</param>
        public static void Fatal(string message)
        {
            try
            {
                if (_instance._log.IsFatalEnabled)
                    _instance._log.Fatal(message);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }

        /// <summary>
        /// 抳柦揑側儘僌傪婰榐偡傞丅
        /// </summary>
        /// <param name="message">儊僢僙乕僕</param>
        /// <param name="ex">椺奜僕僆僽僕僃僋僩</param>
        public static void Fatal(string message, Exception ex)
        {
            try
            {
                if (_instance._log.IsFatalEnabled)
                    _instance._log.Fatal(message, ex);
            }
            catch
            {
                // 儘僌弌椡幐攕偺応崌丄壗傕偟側偄丅
            }
        }
        #endregion
    }
}
