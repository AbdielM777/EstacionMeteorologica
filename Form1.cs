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
            timer1.Interval = 10000;
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
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await ActualizarLabelsAsync();
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await ActualizarLabelsAsync();

        }
    }
}

