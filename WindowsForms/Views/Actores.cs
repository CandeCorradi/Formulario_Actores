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
            BtnAdd.Click += BtnAdd_Click;
            BtnModificar.Click += BtnModificar_Click;
            BtnGoOut.Click += BtnGoOut_Click;

            if (GridActor.Columns.Count == 0)
            {
                // Agregamos las columnas si no existen
                GridActor.Columns.Add("Nombre", "Nombre del Actor");
                GridActor.Columns.Add("Pais", "País de Origen");
                this.GridActor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    this.Nombre,
                    this.Pais});
            }

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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (GridActor.RowCount > 0 && GridActor.SelectedRows.Count > 0)
            {
                var selectedRow = GridActor.SelectedRows[0];

                if (!string.IsNullOrEmpty(TxtNameActor.Text) && CmbPaisActor.SelectedItem != null)
                {
                    // Usar el nombre de la columna
                    selectedRow.Cells["Nombre"].Value = TxtNameActor.Text;
                    selectedRow.Cells["Pais"].Value = CmbPaisActor.SelectedItem.ToString();

                    TxtNameActor.Clear();
                    CmbPaisActor.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese el nombre y seleccione un país.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (GridActor.RowCount > 0 && GridActor.SelectedRows.Count > 0)
            {
                // Eliminar la fila seleccionada
                GridActor.Rows.RemoveAt(GridActor.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
