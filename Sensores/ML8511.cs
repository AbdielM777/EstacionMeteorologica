using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace EstacionMeteorologica.Sensores
{
    public class ML8511 : Sensor
    {
        private static readonly HttpClient client = new HttpClient();
        private string sensorId = "uv-ml8511-1";

        public ML8511() : base("ML8511", "UV Index") { }

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
