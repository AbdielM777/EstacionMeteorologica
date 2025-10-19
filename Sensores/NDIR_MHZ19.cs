using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EstacionMeteorologica.Sensores
{
        public class NDIR_MHZ19 : Sensor
        {
            private static readonly HttpClient client = new HttpClient();
            private string sensorId = "mhz19-1";

            public NDIR_MHZ19() : base("NDIR MH-Z19", "ppm") { }

            public override async Task ActualizarValorAsync()
            {
                try
                {
                    string url = $"http://localhost:8000/reading/{sensorId}?n=1";
                    var response = await client.GetStringAsync(url);
                    var data = JObject.Parse(response);
                    Valor = (double)data["data"][0]["value"];
                    Unidad = (string)data["data"][0]["unit"];
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error MH-Z19: {ex.Message}");
                }
            }
        }
    }

