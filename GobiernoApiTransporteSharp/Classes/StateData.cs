﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GobiernoApiTransporteSharp.Classes
{
    [Serializable]
    public class StateData
    {
        //public AndroidDevice DeviceInfo { get; set; }
        public UserSessionData UserSession { get; set; }
        public bool IsAuthenticated { get; set; }
        //public CookieContainer Cookies { get; set; }
        //public List<Cookie> RawCookies { get; set; }
        //public InstaApiVersionType? InstaApiVersion { get; set; }
    }
}
