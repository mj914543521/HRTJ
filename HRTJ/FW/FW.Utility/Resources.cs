using System.Collections;

namespace FW.Utility
{
    public abstract class Resources
    {
        /// <summary>
        /// 儕僜乕僗傪奿擺偟偰偄傞僐儗僋僔儑儞傪掕媊偡傞丅
        /// </summary>
        protected Hashtable _resourceIds = new Hashtable();

        /// <summary>
        /// 儕僜乕僗ID傪昞帵偡傞偐偳偆偐僼儔僌傪掕媊偡傞丅
        /// </summary>
        protected bool _isShowId = false;

        /// <summary>
        /// 儕僜乕僗僼傽僀儖傪掕媊偡傞丅
        /// </summary>
        protected string _config = string.Empty;

        /// <summary>
        /// 僨僼僅儖偺儕僜乕僗僼僅乕儅僢僩傪掕媊偡傞丅
        /// </summary>
        protected const string DEFAULT_FORMAT = "[{0}]: {1}";

        /// <summary>
        /// 弶婜壔僼儔僌傪掕媊偡傞丅
        /// </summary>
        protected bool _isInitiaized = false;

        /// <summary>
        /// 儘僢僋僆僽僕僃僋僩傪掕媊偡傞丅
        /// </summary>
        protected object _lock = new object();

        /// <summary>
        /// 儕僜乕僗ID傪昞帵偡傞偐偳偆偐僼儔僌傪庢摼傑偨偼愝掕偡傞丅
        /// </summary>
        public bool IsShowId
        {
            get
            {
                return _isShowId;
            }
            set
            {
                _isShowId = value;
            }
        }

        /// <summary>
        /// 儕僜乕僗僼傽僀儖傪庢摼偡傞丅
        /// </summary>
        public string Config
        {
            get
            {
                return _config;
            }
        }

        /// <summary>
        /// 怴偟偄僀儞僗僞儞僗傪弶婜壔偡傞丅
        /// </summary>
        /// <param name="config">儕僜乕僗僼傽僀儖</param>
        public Resources(string config)
        {
            this._config = config;
            this._isInitiaized = false;
        }

        /// <summary>
        /// 怴偟偄僀儞僗僞儞僗傪弶婜壔偡傞丅
        /// </summary>
        /// <param name="config">儕僜乕僗僼傽僀儖</param>
        /// <param name="isShowId">儕僜乕僗ID傪昞帵偡傞偐偳偆偐僼儔僌</param>
        public Resources(string config, bool isShowId)
        {
            this._config = config;
            this._isShowId = IsShowId;
            this._isInitiaized = false;
        }

        /// <summary>
        /// 儕僜乕僗ID傪巜掕偟偰儕僜乕僗撪梕傪庢摼偡傞丅
        /// </summary>
        /// <param name="resourceId">儕僜乕僗ID</param>
        /// <param name="args">奺僷儔儊乕僞抣</param>
        /// <returns>儕僜乕僗撪梕</returns>
        public virtual object GetResource(string resourceId, params object[] args)
        {
            object content = PreGetResource(resourceId, args);
            content = PostGetResource(content, resourceId, args);
            return content;
        }

        /// <summary>
        /// 儕僜乕僗ID傪巜掕偟偰儕僜乕僗撪梕傪庢摼偡傞丅
        /// </summary>
        /// <param name="resourceId">儕僜乕僗ID</param>
        /// <param name="args">奺僷儔儊乕僞抣</param>
        /// <returns>儕僜乕僗撪梕</returns>
        protected virtual object PreGetResource(string resourceId, params object[] args)
        {
            if (resourceId == null)
                return null;

            // 儕僜乕僗撪梕傪庢摼偡傞丅
            object content = null;
            if (!_isInitiaized)
            {
                lock (_lock)
                {
                    if (!_isInitiaized)
                    {
                        // 儕僜乕僗撪梕傪弶婜壔偡傞丅
                        ReleaseResources();
                        InitResources();
                        _isInitiaized = true;
                    }
                }
            }

            content = _resourceIds[resourceId];
            return content;
        }

        /// <summary>
        /// 儕僜乕僗ID傪巜掕偟偰儕僜乕僗撪梕傪庢摼偡傞丅
        /// </summary>
        /// <param name="resource">儕僜乕僗</param>
        /// <param name="resourceId">儕僜乕僗ID</param>
        /// <param name="args">奺僷儔儊乕僞抣</param>
        /// <returns>儕僜乕僗撪梕</returns>
        protected virtual object PostGetResource(object resource, string resourceId, params object[] args)
        {
            return resource;
        }

        /// <summary>
        /// 儕僜乕僗撪梕傪弶婜壔偡傞丅
        /// </summary>
        protected abstract void InitResources();

        /// <summary>
        /// 儕僜乕僗撪梕傪夝曻偡傞丅
        /// </summary>
        protected virtual void ReleaseResources()
        {
            lock (_lock)
            {
                _resourceIds.Clear();
                _isInitiaized = false;
            }
        }
    }
}
