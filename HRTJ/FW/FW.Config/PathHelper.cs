
using System.IO;
namespace FW.Config
{
    public sealed class PathHelper
    {
        /// <summary>
        /// 憡懳僷僗偺愙摢梫慺傪掕媊偡傞丅
        /// </summary>
        public const string PREFIX_RELATIVE_PATH = @"~/";

        /// <summary>
        /// 巜掕偟偨僷僗偑憡懳僷僗偐偳偆偐傪敾抐偡傞丅
        /// </summary>
        /// <param name="path">僷僗</param>
        /// <returns>敾抐寢壥</returns>
        public static bool IsRelativePath(string path)
        {
            if (path == null)
                return false;
            else
                return path.StartsWith(PREFIX_RELATIVE_PATH);
        }

        /// <summary>
        /// 巜掕偟偨僷僗偑愨懳僷僗偐偳偆偐傪敾抐偡傞丅
        /// </summary>
        /// <param name="path">僷僗</param>
        /// <returns>敾抐寢壥</returns>
        public static bool IsAbsolutePath(string path)
        {
            if (path == null)
                return false;
            else
                return !IsRelativePath(path);
        }

        /// <summary>
        /// 巜掕偟偨僷僗偑憡懳僷僗偐偳偆偐傪敾抐偟偰丄憡懳僷僗偺応崌偼丄尦憡懳僷僗傪栠傞丅
        /// </summary>
        /// <param name="path">僷僗</param>
        /// <returns>尦憡懳僷僗</returns>
        public static string GetRelativePath(string path)
        {
            if (IsRelativePath(path))
                return path.Substring(PREFIX_RELATIVE_PATH.Length);

            return path;
        }

        /// <summary>
        /// 巜掕偟偨僷僗傪愨懳僷僗偵曄姺偟偰栠傞丅
        /// </summary>
        /// <param name="path">僷僗</param>
        /// <returns>愨懳僷僗</returns>
        public static string GetAbsolutePath(string path)
        {
            string retPath = path;
            if (IsRelativePath(retPath))
            {
                retPath =Path.Combine(ConfigManager.SystemBasePath , GetRelativePath(path));
            }
            return retPath;
        }
    }
}
