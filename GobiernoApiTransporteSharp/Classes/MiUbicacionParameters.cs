using System;
using System.Collections.Generic;
using System.Text;

namespace GobiernoApiTransporteSharp.Classes
{
    public class MiUbicacionParameters
    {
        //Longitud
        public string X { get; set; } = "0";
        //Latitud
        public string Y { get; set; } = "0";
        public long Radio { get; set; } = 100;
        public string Orden { get; set; } = "distancia";
        public bool FullInfo { get; set; } = true;
    }
}
