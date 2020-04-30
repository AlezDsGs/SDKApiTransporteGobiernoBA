using System;
using System.Collections.Generic;
using System.Text;

namespace GobiernoApiTransporteSharp.Enums
{
    public enum GobiernoApiVersionType
    {
        /// <summary>
        ///     Default api version. v44.0.0.9.93 => No more consent required error.
        /// </summary>
        v0 = 0,
        /// <summary>
        ///     Api version => No more consent required error.
        /// </summary>
        v1 = 1,
        /// <summary>
        ///     Api version 61.0.0.19.86 => All data like signature key, version code and ... is for v44 except instagram version
        /// </summary>
        v2 = 2,
    }
}
