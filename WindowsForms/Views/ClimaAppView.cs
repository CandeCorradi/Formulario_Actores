using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Models;
using WindowsForms.Views;

namespace WindowsForms
{
    public partial class ClimaAppView : Form
    {
        public ClimaAppView()
        {
            InitializeComponent();
        }

        private void subMenuSalirDeLaApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonSalirApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonNosotros_Click(object sender, EventArgs e)
        {
            NosotrosView nosotrosView = new NosotrosView();
            nosotrosView.ShowDialog();
        }

        private void subMenuNosotros_Click(object sender, EventArgs e)
        {
            botonNosotros_Click(sender, e);
        }

        private async void BtnObtenerClima_Click(object sender, EventArgs e)
        {
            string url = "https://api.open-meteo.com/v1/forecast?latitude=-30.78362&longitude=-60.59115&current=temperature_2m,relative_humidity_2m";

            var clientHttp = new HttpClient();
            var response = await clientHttp.GetAsync(url);
            if (response != null)
            {
                QueryTemperature queryTemperature = await response.Content.ReadFromJsonAsync<QueryTemperature>();
                this.labelTemperatura.Text = $"{queryTemperature.current.temperature_2m} °C";
            }
        }
    }
}
