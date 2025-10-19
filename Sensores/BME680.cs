using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace EstacionMeteorologica.Sensores
{
    public class BME680 : Sensor
    {
        private static readonly HttpClient client = new HttpClient();
        private string sensorId = "bme680-1";

        public BME680() : base("BME680", "°C / % / hPa / TVOC") { }

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
