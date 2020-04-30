using GobiernoApiTransporteSharp.API.Processors;
using GobiernoApiTransporteSharp.Classes;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace GobiernoApiTransporteSharp.API
{
    /// <summary>
    ///     Base of everything that you want.
    /// </summary>
    public interface IGobiernoApi
    {
        /// <summary>
        ///     Current HttpClient
        /// </summary>
        HttpClient HttpClient { get; }
        /// <summary>
        /// <summary>
        ///     Comments api functions.
        /// </summary>
        ITransitoProcessor TransitoProcessor { get; }
        UserSessionData GetLoggedUser();
    }
}
