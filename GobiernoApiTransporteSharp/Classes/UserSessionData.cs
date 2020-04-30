using System;
using System.Collections.Generic;
using System.Text;

namespace GobiernoApiTransporteSharp.Classes
{
    [Serializable]
    public class UserSessionData
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }

        public static UserSessionData Empty => new UserSessionData();

    }
}
