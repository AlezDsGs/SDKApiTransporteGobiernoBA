using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GobiernoApiTransporteSharp.Classes.ResponseWrappers.Transito
{
    public class EstacionamientoCercaListResponse
    {
        [JsonProperty("totalFull")]
        public int EstacionamientosEncontrados { get; set; }
        [JsonProperty("instancias")]
        internal List<Estacionamiento> Resultados { get; set; }
    }

    public class Estacionamiento
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("distancia")]
        public double Distancia { get; set; }
        [JsonProperty("contenido")]
        public DetalleEstacionamiento DetalleDelEstacionamiento { get; set; }
    }

    public class DetalleEstacionamiento
    {
        [JsonProperty("contenido")]
        public List<Detalle> Detalles { get; set; }
    }

    public class Detalle
    {
        [JsonProperty("nombreId")]
        public string DescripcionId { get; set; }
        [JsonProperty("nombre")]
        public string Descripcion { get; set; }
        [JsonProperty("valor")]
        public string Valor { get; set; }
    }
}
