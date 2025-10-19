using EstacionMeteorologica.Sensores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionMeteorologica
{
    public partial class Form1 : Form
    {
        private PMS5003 sensorPMS5003;
        private MHZ19 sensorMHZ19;
        private BME680 sensorBME680;
        private FS300A sensorFS300A;
        private YL83 sensorYL83;
        private ML8511 sensorML8511;

        public Form1()
        {
            InitializeComponent();

            sensorPMS5003 = new PMS5003();
            sensorMHZ19 = new MHZ19();
            sensorBME680 = new BME680();
            sensorFS300A = new FS300A();
            sensorYL83 = new YL83();
            sensorML8511 = new ML8511();
            timer1.Interval = 6000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await ActualizarLabelsAsync();
        }

        private async Task ActualizarLabelsAsync()
        {
            await sensorPMS5003.ActualizarValorAsync();
            await sensorMHZ19.ActualizarValorAsync();
            await sensorBME680.ActualizarValorAsync();
            await sensorFS300A.ActualizarValorAsync();
            await sensorYL83.ActualizarValorAsync();
            await sensorML8511.ActualizarValorAsync();

            lblPMS5003.Text = $"PMS5003: {sensorPMS5003.Valor} {sensorPMS5003.Unidad}";
            lblMHZ19.Text = $"MH-Z19: {sensorMHZ19.Valor} {sensorMHZ19.Unidad}";
            lblBME680.Text = $"BME680: {sensorBME680.Valor} {sensorBME680.Unidad}";
            lblFS300A.Text = $"FS300A: {sensorFS300A.Valor} {sensorFS300A.Unidad}";
            lblYL83.Text = $"YL-83: {sensorYL83.Valor} {sensorYL83.Unidad}";
            lblML8511.Text = $"ML8511: {sensorML8511.Valor} {sensorML8511.Unidad}";
            ActualizarDashboard();

        }
        private void ActualizarDashboard()
        {
            string dashboard = "";


            if (sensorPMS5003.Valor <= 12) dashboard += "PM2.5: bueno. ";
            else if (sensorPMS5003.Valor <= 35) dashboard += "PM2.5: regular. ";
            else dashboard += "PM2.5: alto. ";

            if (sensorMHZ19.Valor <= 1000) dashboard += "CO2 normal. ";
            else if (sensorMHZ19.Valor <= 2000) dashboard += "CO2 elevado. ";
            else dashboard += "CO2 peligroso. ";

            if (sensorBME680.Valor >= 18 && sensorBME680.Valor <= 26) dashboard += "Temperatura confortable. ";
            else if (sensorBME680.Valor < 18) dashboard += "Hace frío. ";
            else dashboard += "Hace calor. ";

            
            if (sensorBME680.Unidad.Contains("%")) 
            {
                if (sensorBME680.Valor >= 30 && sensorBME680.Valor <= 60) dashboard += "Humedad ideal. ";
                else dashboard += "Humedad fuera de rango. ";
            }

            if (sensorFS300A.Valor < 3) dashboard += "Viento leve. ";
            else if (sensorFS300A.Valor < 8) dashboard += "Viento moderado. ";
            else dashboard += "Viento fuerte. ";

            if (sensorYL83.Valor == 0) dashboard += "Sin lluvia. ";
            else dashboard += "Está lloviendo. ";

            if (sensorML8511.Valor <= 2) dashboard += "UV bajo. ";
            else if (sensorML8511.Valor <= 5) dashboard += "UV moderado. ";
            else if (sensorML8511.Valor <= 7) dashboard += "UV alto. ";
            else if (sensorML8511.Valor <= 10) dashboard += "UV muy alto. ";
            else dashboard += "UV extremo. ";

            lblDashboard.Text = dashboard;
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await ActualizarLabelsAsync();

        }

        private async void btnActualizar_Click_1(object sender, EventArgs e)
        {
            await ActualizarLabelsAsync();

        }
    }
}

