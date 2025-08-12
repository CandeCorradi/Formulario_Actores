using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Services;

namespace WindowsForms.Views
{
    public partial class Actores : Form
    {
        //instanciamos el servicio
        public Actores()
        {
            InitializeComponent();

            //Lista de paises
            var paises = new List<string>
            {
                "Argentina",
                "Brasil",
                "Estados Unidos",
                "España",
                "Francia",
                "Italia",
                "Alemania",
                "México",
                "Reino Unido",
                "Japón",
                "Canadá",
                "Australia",
                "India",
                "China"
            };
            CmbPaisActor.Items.AddRange(paises.ToArray());
        }

        private void CmbPaisActor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cargo el pais del actor que escribi en txtNameActor en el combo
            if (!string.IsNullOrEmpty(TxtNameActor.Text))
            {
                GridActor.Rows.Add(TxtNameActor.Text, CmbPaisActor.SelectedItem.ToString());
                TxtNameActor.Clear();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNameActor.Text) && CmbPaisActor.SelectedItem != null)
            {
                GridActor.Rows.Add(TxtNameActor.Text, CmbPaisActor.SelectedItem.ToString());
                TxtNameActor.Clear();
                CmbPaisActor.SelectedIndex = -1;
            }
        }

        private void BtnGoOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
