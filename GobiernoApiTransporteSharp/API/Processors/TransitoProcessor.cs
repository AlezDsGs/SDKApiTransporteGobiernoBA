using GobiernoApiTransporteSharp.Classes;
using GobiernoApiTransporteSharp.Classes.Models.Transito;
using GobiernoApiTransporteSharp.Classes.ResponseWrappers.Transito;
using GobiernoApiTransporteSharp.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GobiernoApiTransporteSharp.API.Processors
{
    internal class TransitoProcessor : ITransitoProcessor
    {
        private readonly HttpHelper _httpHelper;
        private readonly IHttpRequestProcessor _httpRequestProcessor;
        private readonly GobiernoApi _gobiernoApi;
        //private readonly IGobiernoLogger _logger;
        private readonly UserSessionData _user;
        //private readonly UserAuthValidate _userAuthValidate;
        public TransitoProcessor(UserSessionData user,
            IHttpRequestProcessor httpRequestProcessor /*,IGobiernoLogger logger,*/
            /*UserAuthValidate userAuthValidate*/, GobiernoApi gobiernoApi, HttpHelper httpHelper)
        {
            _user = user;
            _httpRequestProcessor = httpRequestProcessor;
            //_logger = logger;
            _gobiernoApi = gobiernoApi;
            _httpHelper = httpHelper;
        }
        public async Task<EstacionamientoCercaListResponse> GetTransitoEstacionamientosAsync(MiUbicacionParameters miUbicacion)
        {
            try
            {
                var transitoEstacionamientosUri = UriCreator.GetTransitoEstacionamientosUri(_user, miUbicacion);


                var request = _httpHelper.GetDefaultRequest(HttpMethod.Get, transitoEstacionamientosUri);
                var response = await _httpRequestProcessor.SendAsync(request);
                var json = await response.Content.ReadAsStringAsync();
                //if (response.StatusCode != HttpStatusCode.OK)
                //    return Result.UnExpectedResponse<GobiernoCommentList>(response, json);


                var EstacionamientosResponse = JsonConvert.DeserializeObject<EstacionamientoCercaListResponse>(json);

                Expression<Func<int, int, int>> asd = (a, b) => a * b;


                //var converter = ConvertersFabric.Gobiernonce.GetCommentListConverter(commentListResponse);
                //return Result.Success(converter.Convert());

                return EstacionamientosResponse;
            }
            catch (HttpRequestException httpException)
            {

                throw httpException;
                //    _logger?.LogException(httpException);
                //    return Result.Fail(httpException, default(GobiernoCommentList), ResponseType.NetworkProblem);
                //}
                //catch (Exception exception)
                //{
                //    _logger?.LogException(exception);
                //    return Result.Fail<GobiernoCommentList>(exception);


            }
        }
    }
}
