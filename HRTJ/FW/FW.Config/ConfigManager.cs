using System;
using System.Configuration;
using System.IO;
using System.Web.Configuration;
namespace FW.Config
{
    public class ConfigManager
    {
        /// <summary>
        /// 僂僃僽傾僾儕偐偳偆偐僼儔僌傪掕媊偡傞丅
        /// </summary>
        private static bool _isWeb = false;

        /// <summary>
        /// 僔僗僥儉偺弶婜婲摦僷僗傪掕媊偡傞丅
        /// </summary>
        private static string _systemBasePath = AppDomain.CurrentDomain.BaseDirectory;

        /// <summary>
        /// 弶婜壔僼儔僌傪掕媊偡傞丅
        /// </summary>
        private static bool _isInitiaized = false;

        /// <summary>
        /// 僔僗僥儉偺弶婜婲摦僷僗傪庢摼偡傞丅
        /// </summary>
        public static string SystemBasePath
        {
            get
            {
                if (!_isInitiaized)
                    Initialize();

                return _systemBasePath;
            }
        }

        /// <summary>
        /// 僂僃僽傾僾儕偐偳偆偐僼儔僌傪庢摼偡傞丅
        /// </summary>
        public static bool IsWeb
        {
            get
            {
                if (!_isInitiaized)
                    Initialize();

                return _isWeb;
            }
        }

        /// <summary>
        /// 怴偟偄僀儞僗僞儞僗傪弶婜壔偡傞丅
        /// </summary>
        private ConfigManager()
        {
        }

        /// <summary>
        /// 奺僼傿乕儖僪抣傪弶婜壔偡傞丅
        /// </summary>
        public static void Initialize()
        {
            try
            {
                if (!_isInitiaized)
                {
                    _systemBasePath = GetSystemBasePath();
                    _isWeb = GetAppType();

                    _isInitiaized = true;
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        /// <summary>
        /// 峔惉崁栚傪庢摼偡傞丅
        /// </summary>
        /// <param name="key">峔惉僉乕</param>
        /// <returns>峔惉抣</returns>
        public static string GetConnectionString(string key)
        {
            return GetConnectionSetting(key).ConnectionString;
        }

        /// <summary>
        /// 峔惉崁栚傪庢摼偡傞丅
        /// </summary>
        /// <param name="key">峔惉僉乕</param>
        /// <returns>峔惉抣</returns>
        public static ConnectionStringSettings GetConnectionSetting(string key)
        {
            if (!_isInitiaized)
                Initialize();

            if (IsWeb)
                return WebConfigurationManager.ConnectionStrings[key];
            else
                return ConfigurationManager.ConnectionStrings[key];
        }

        /// <summary>
        /// 峔惉崁栚傪庢摼偡傞丅
        /// </summary>
        /// <returns>峔惉抣</returns>
        public static ConnectionStringSettingsCollection GetConnectionSettings()
        {
            if (!_isInitiaized)
                Initialize();

            if (IsWeb)
                return WebConfigurationManager.ConnectionStrings;
            else
                return ConfigurationManager.ConnectionStrings;
        }

        /// <summary>
        /// 峔惉崁栚傪庢摼偡傞丅
        /// </summary>
        /// <param name="key">峔惉僉乕</param>
        /// <returns>峔惉抣</returns>
        public static string GetAppConfig(string key)
        {
            if (!_isInitiaized)
                Initialize();

            if (IsWeb)
                return WebConfigurationManager.AppSettings[key];
            else
                return ConfigurationManager.AppSettings[key];
        }


        /// <summary>
        /// 僔僗僥儉偺弶婜婲摦僷僗傪庢摼偡傞丅
        /// </summary>
        private static string GetSystemBasePath()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            if (!path.EndsWith(Path.DirectorySeparatorChar + ""))
                path += Path.DirectorySeparatorChar;

            return path;
        }

        /// <summary>
        /// 僂僃僽傾僾儕偐偳偆偐傪敾抐偡傞丅
        /// </summary>
        /// <returns>敾抐寢壥</returns>
        private static bool GetAppType()
        {
            if (System.Web.HttpContext.Current != null)
            {
                return true;
            }
            return false;
        }
    }
}
