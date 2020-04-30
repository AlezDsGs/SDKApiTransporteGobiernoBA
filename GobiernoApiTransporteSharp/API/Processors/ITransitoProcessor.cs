using GobiernoApiTransporteSharp.Classes;
using GobiernoApiTransporteSharp.Classes.Models.Transito;
using GobiernoApiTransporteSharp.Classes.ResponseWrappers.Transito;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GobiernoApiTransporteSharp.API.Processors
{
    /// <summary>
    ///     Transito api functions.
    /// </summary>
    /// 
    public interface ITransitoProcessor
    {
        /// <summary>
        ///     Get media comments
        /// </summary>
        /// <param name="mediaId">Media id</param>
        /// <param name="paginationParameters">Pagination parameters: next id and max amount of pages to load</param>
        //Task<IResult<EstacionamientoCercaList>>
        //    GetMediaCommentsAsync(string mediaId, MiUbicacionParameters miUbicacionParameters);

        Task<EstacionamientoCercaListResponse> GetTransitoEstacionamientosAsync(MiUbicacionParameters miUbicacion);

    }
}
