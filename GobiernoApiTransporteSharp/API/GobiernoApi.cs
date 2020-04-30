using GobiernoApiTransporteSharp.API.Processors;
using GobiernoApiTransporteSharp.API.Versions;
using GobiernoApiTransporteSharp.Classes;
using GobiernoApiTransporteSharp.Enums;
using GobiernoApiTransporteSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace GobiernoApiTransporteSharp.API
{
    internal class GobiernoApi : IGobiernoApi
    {

        private ITransitoProcessor _TransitoProcessor;
        //private IUserProcessor _userProcessor;
        private readonly IHttpRequestProcessor _httpRequestProcessor;
        private UserSessionData _userSession;
        private UserSessionData _user
        {
            get { return _userSession; }
            set { _userSession = value; }
        }


        //private readonly IGobiernoLogger _logger;
        private GobiernoApiVersionType _apiVersionType;
        private GobiernoApiVersion _apiVersion;
        private HttpHelper _httpHelper { get; set; }






        public GobiernoApi(UserSessionData user, /*IGobiernoLogger logger,*/
                            IHttpRequestProcessor httpRequestProcessor, GobiernoApiVersionType apiVersionType)
        {


            //_logger = logger;

            _httpRequestProcessor = httpRequestProcessor;
            _apiVersionType = apiVersionType;
            _apiVersion = GobiernoApiVersionList.GetApiVersionList().GetApiVersion(apiVersionType);
            _httpHelper = new HttpHelper(/*_apiVersion,*/ httpRequestProcessor, this);
            _userSession = user;

            LoadStateDataFromObject(new StateData { UserSession = _user });
        }



        //private void ValidateRequestMessage()
        //{
        //    if (_httpRequestProcessor.RequestMessage == null || _httpRequestProcessor.RequestMessage.IsEmpty())
        //        throw new ArgumentException("API request message null or empty");
        //}

        //private void LogException(Exception exception)
        //{
        //    _logger?.LogException(exception);
        //}



        /// <summary>
        ///     Current HttpClient
        /// </summary>
        public HttpClient HttpClient { get => _httpRequestProcessor.Client; }
        /// <summary>
        ///     Current <see cref="IHttpRequestProcessor"/>
        /// </summary>
        public IHttpRequestProcessor HttpRequestProcessor => _httpRequestProcessor;

        /// <summary>
        ///     Comments api functions.
        /// </summary>
        public ITransitoProcessor TransitoProcessor => _TransitoProcessor;


        /// <summary>
        ///     Set timeout to <see cref="HttpClient"/>
        ///     <para>Note: Set timeout more than 100 seconds!</para>
        /// </summary>
        /// <param name="timeout">Timeout (set more than 100 seconds!)</param>
        public void SetTimeout(TimeSpan timeout)
        {
            if (timeout == null)
                timeout = TimeSpan.FromSeconds(350);

            HttpClient.Timeout = timeout;
        }
        /// <summary>
        ///     Set custom HttpClientHandler to be able to use certain features, e.g Proxy and so on
        /// </summary>
        /// <param name="handler">HttpClientHandler</param>
        public void UseHttpClientHandler(HttpClientHandler handler)
        {
            _httpRequestProcessor.SetHttpClientHandler(handler);
        }

        /// <summary>
        ///     Gets logged in user
        /// </summary>
        public UserSessionData GetLoggedUser()
        {
            return _user;
        }


        private void InvalidateProcessors()
        {
            _TransitoProcessor = new TransitoProcessor(_user, _httpRequestProcessor, this, _httpHelper);
        }

        public void LoadStateDataFromObject(StateData stateData)
        {

            _user = stateData.UserSession;

            //Load Stream Edit 
            //_httpRequestProcessor.RequestMessage.Username = stateData.UserSession.UserName;
            //_httpRequestProcessor.RequestMessage.Password = stateData.UserSession.Password;

            //_httpRequestProcessor.RequestMessage.DeviceId = stateData.DeviceInfo.DeviceId;
            //_httpRequestProcessor.RequestMessage.PhoneId = stateData.DeviceInfo.PhoneGuid.ToString();
            //_httpRequestProcessor.RequestMessage.Guid = stateData.DeviceInfo.DeviceGuid;
            //_httpRequestProcessor.RequestMessage.AdId = stateData.DeviceInfo.AdId.ToString();

            //foreach (var cookie in stateData.RawCookies)
            //{
            //    _httpRequestProcessor.HttpHandler.CookieContainer.Add(new Uri(InstaApiConstants.INSTAGRAM_URL), cookie);
            //}

            //if (stateData.InstaApiVersion == null)
            //    stateData.InstaApiVersion = InstaApiVersionType.Version126;
            //_apiVersionType = stateData.InstaApiVersion.Value;
            //_apiVersion = InstaApiVersionList.GetApiVersionList().GetApiVersion(_apiVersionType);
            _httpHelper = new HttpHelper(HttpRequestProcessor, this);

            //IsUserAuthenticated = stateData.IsAuthenticated;
            InvalidateProcessors();


        }
    }
}
