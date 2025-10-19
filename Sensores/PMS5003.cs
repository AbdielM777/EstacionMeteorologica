using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EstacionMeteorologica.Sensores
{
    public class PMS5003 : Sensor
    {
        private static readonly HttpClient client = new HttpClient();
        private string sensorId = "pms5003-1";

        public PMS5003() : base("PMS5003", "µg/m³") { }

        public override async Task ActualizarValorAsync()
        {
            try
            {
                string url = $"http://127.0.0.1:8000/reading/{sensorId}?n=1";
                var response = await client.GetStringAsync(url);
                var data = JObject.Parse(response);
                Valor = (double)data["data"][0]["value"];
                Unidad = (string)data["data"][0]["unit"];
            }
            catch { Valor = 0; Unidad = ""; }
        }
    }
}