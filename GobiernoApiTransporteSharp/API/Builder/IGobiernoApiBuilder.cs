using GobiernoApiTransporteSharp.Classes;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace GobiernoApiTransporteSharp.API.Builder
{
    public interface IGobiernoApiBuilder
    {
        /// <summary>
        ///     Create new API instance
        /// </summary>
        /// <returns>API instance</returns>
        IGobiernoApi Build();

        ///// <summary>
        /////     Use custom logger
        ///// </summary>
        ///// <param name="logger">IGobiernoLogger implementation</param>
        ///// <returns>API Builder</returns>
        //IGobiernoApiBuilder UseLogger(IGobiernoLogger logger);

        /// <summary>
        ///     Set specific HttpClient
        /// </summary>
        /// <param name="httpClient">HttpClient</param>
        /// <returns>API Builder</returns>
        IGobiernoApiBuilder UseHttpClient(HttpClient httpClient);



        /// <summary>
        ///     Specify user login, password from here
        /// </summary>
        /// <param name="user">User auth data</param>
        /// <returns>API Builder</returns>
        IGobiernoApiBuilder SetUser(UserSessionData user);


        ///// <summary>
        /////     Set instagram api version (for user agent version)
        ///// </summary>
        ///// <param name="apiVersion">Api version</param>
        //IGobiernoApiBuilder SetApiVersion(GobiernoApiVersionType apiVersion);

        ///// <summary>
        /////     Set Http request processor
        ///// </summary>
        ///// <param name="httpRequestProcessor">HttpRequestProcessor</param>
        ///// <returns></returns>
        //IGobiernoApiBuilder SetHttpRequestProcessor(IHttpRequestProcessor httpRequestProcessor);

    }
}
