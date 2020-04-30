using System;
using System.Collections.Generic;
using System.Text;

namespace GobiernoApiTransporteSharp.API
{
    internal static class GobiernoApiConstants
    {
        public const string HOST_URI = "i.instagram.com";

        public const string API = "/api";
        public const string API_VERSION = "/v1";
        public const string TRANSITO_SUFFIX = "/transito";
        public const string ESTACIONAMIENTO_SUFFIX = "/estacionamientos";
        public const string API_SUFFIX = API + API_VERSION;
        public const string GOBIERNO_API_URL = "https://apitransporte.buenosaires.gob.ar";

        public const string TRANSITOESTACIONAMIENTO_COMPLETE_URL = GOBIERNO_API_URL + TRANSITO_SUFFIX + ESTACIONAMIENTO_SUFFIX + "/";
        public const string TRANSITOESTACIONAMIENTO_URL = TRANSITO_SUFFIX + API_VERSION + ESTACIONAMIENTO_SUFFIX;


        public const string SET_ACCOUNT_PRIVATE = API_SUFFIX + "/accounts/set_private/";



    }
}
