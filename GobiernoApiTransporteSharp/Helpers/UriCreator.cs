using GobiernoApiTransporteSharp.API;
using GobiernoApiTransporteSharp.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace GobiernoApiTransporteSharp.Helpers
{
    internal class UriCreator
    {
        private static readonly Uri BaseInstagramUri = new Uri(GobiernoApiConstants.GOBIERNO_API_URL);


        public static Uri GetTransitoEstacionamientosUri(UserSessionData userSessionData, MiUbicacionParameters miUbicacion)
        {
            if (!Uri.TryCreate(BaseInstagramUri, GobiernoApiConstants.TRANSITOESTACIONAMIENTO_URL, out var instaUri))
                throw new Exception("Cant create URI for set account private");

            instaUri = instaUri.AddQuery("client_id", userSessionData.ClientId)
            .AddQuery("client_secret", userSessionData.ClientSecret)
            .AddQuery("x", miUbicacion.X)
            .AddQuery("y", miUbicacion.Y)
            .AddQuery("radio", miUbicacion.Radio.ToString())
            .AddQuery("orden", miUbicacion.Orden)
            .AddQuery("fullInfo", miUbicacion.FullInfo.ToString())
            ;


            var prueba = instaUri;

            return instaUri;
        }


    }
}
