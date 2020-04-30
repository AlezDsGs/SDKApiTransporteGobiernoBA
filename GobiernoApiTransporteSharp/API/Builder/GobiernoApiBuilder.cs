using GobiernoApiTransporteSharp.Classes;
using GobiernoApiTransporteSharp.Enums;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace GobiernoApiTransporteSharp.API.Builder
{
    public class GobiernoApiBuilder : IGobiernoApiBuilder
    {
        private HttpClient _httpClient;
        private HttpClientHandler _httpHandler = new HttpClientHandler();
        private UserSessionData _user;
        private IHttpRequestProcessor _httpRequestProcessor;
        private GobiernoApiVersionType? _apiVersionType;


        public IGobiernoApi Build()
        {
            if (_user == null)
                _user = UserSessionData.Empty;

            if (_httpHandler == null) _httpHandler = new HttpClientHandler();

            if (_httpClient == null)
                _httpClient = new HttpClient(_httpHandler) { BaseAddress = new Uri(GobiernoApiConstants.GOBIERNO_API_URL) };




            //try
            //{
            //    GobiernoApiConstants.TIMEZONE_OFFSET = int.Parse(DateTimeOffset.Now.Offset.TotalSeconds.ToString());
            //}
            //catch { }

            if (_httpRequestProcessor == null)
                _httpRequestProcessor =
                    new HttpRequestProcessor(_httpClient, _httpHandler/*,_logger*/);

            if (_apiVersionType == null)
                _apiVersionType = GobiernoApiVersionType.v1;

            var instaApi = new GobiernoApi(_user, /*_logger, */_httpRequestProcessor, _apiVersionType.Value);
            //if (_sessionHandler != null)
            //{
            //    _sessionHandler.GobiernoApi = instaApi;
            //    instaApi.SessionHandler = _sessionHandler;
            //}
            return instaApi;
        }

        /// <summary>
        ///     Specify user login, password from here
        /// </summary>
        /// <param name="user">User auth data</param>
        /// <returns>
        ///     API Builder
        /// </returns>
        public IGobiernoApiBuilder SetUser(UserSessionData user)
        {
            _user = user;
            return this;
        }

        /// <summary>
        ///     Set specific HttpClient
        /// </summary>
        /// <param name="httpClient">HttpClient</param>
        /// <returns>
        ///     API Builder
        /// </returns>
        public IGobiernoApiBuilder UseHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            return this;
        }

        /// <summary>
        ///     Creates the builder.
        /// </summary>
        /// <returns>
        ///     API Builder
        /// </returns>
        public static IGobiernoApiBuilder CreateBuilder()
        {
            return new GobiernoApiBuilder();
        }
    }
}
