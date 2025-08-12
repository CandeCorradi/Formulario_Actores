using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Views
{
    public partial class Cine : Form
    {
        public Cine()
        {
            InitializeComponent();

            // Configurar la grilla si no tiene columnas
            if (GridStudy.Columns.Count == 0)
            {
                GridStudy.Columns.Add("NombreEstudio", "Nombre del Estudio");
                GridStudy.Columns["NombreEstudio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del estudio desde el TextBox
            string nombreEstudio = TxtEstudio.Text.Trim();

            // Validar que no esté vacío
            if (!string.IsNullOrEmpty(nombreEstudio))
            {
                // Agregar el nombre como nueva fila en la grilla
                GridStudy.Rows.Add(nombreEstudio);

                // Limpiar el TextBox para el próximo ingreso
                TxtEstudio.Clear();
                GridStudy.ClearSelection();
                TxtEstudio.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el nombre del estudio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnGoOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
