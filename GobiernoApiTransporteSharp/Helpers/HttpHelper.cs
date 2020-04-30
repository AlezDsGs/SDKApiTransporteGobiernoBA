using GobiernoApiTransporteSharp.API;
using GobiernoApiTransporteSharp.Classes;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace GobiernoApiTransporteSharp.Helpers
{
    internal class HttpHelper
    {
        //public /*readonly*/ InstaApiVersion _apiVersion;
        //readonly Random Rnd = new Random();
        public IHttpRequestProcessor _httpRequestProcessor;
        public IGobiernoApi _gobiernoApi;
        internal HttpHelper(IHttpRequestProcessor httpRequestProcessor, IGobiernoApi gobiernoApi)
        {
            _httpRequestProcessor = httpRequestProcessor;
            _gobiernoApi = gobiernoApi;
        }


        public HttpRequestMessage GetDefaultRequest(HttpMethod method, Uri uri)
        {
            var request = new HttpRequestMessage(method, uri);
            return request;
        }
    }
}
