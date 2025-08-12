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
using WindowsForms.Services;

namespace WindowsForms.Views
{
    public partial class PaisesEFView : Form
    {
        //instanciamos el servicio
        PaisEFService paisEFService = new PaisEFService();
        Pais paisCurrent;
        List<Pais>? paises;

        public PaisesEFView()
        {
            InitializeComponent();
            ObtenemosPaises();
        }
        private async void ObtenemosPaises()
        {
            paises = await paisEFService.GetAllAsync();
            GridPaises.DataSource = paises;
            GridPaises.Columns["Id"].Visible = false; // Ocultamos la columna Pais
            GridPaises.Columns["Eliminado"].Visible = false; // Ocultamos la columna Eliminado
        }
        private async void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
            if (GridPaises.RowCount > 0 && GridPaises.SelectedRows.Count > 0)
            {
                Pais paisSelected = (Pais)GridPaises.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea eliminar el pais {paisSelected.Nombre}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await paisEFService.DeleteAsync(paisSelected.Id))
                    {
                        LabelStatusMessage.Text = $"Pais {paisSelected.Nombre} eliminado correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        ObtenemosPaises();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el pais", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una pelicula para eliminarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarControlesAgregarEditar();
            TabControl.SelectTab("TabPageAgregarEditar");
        }

        private void LimpiarControlesAgregarEditar()
        {
            TxtNombre.Clear();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageLista");

        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            Pais paisToSave = new Pais
            {
                Id = paisCurrent?.Id ?? 0, 
                Nombre = TxtNombre.Text
            };

            bool response;
            if (paisCurrent!= null)
            {
                response=await paisEFService.UpdateAsync(paisToSave);
            }
            else
            {
                response = await paisEFService.AddAsync(paisToSave);
            }
            if (response)
            {
                paisCurrent = null; // Reset the modified movie after saving
                LabelStatusMessage.Text = "Pais guardado correctamente";
                TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                ObtenemosPaises();
                LimpiarControlesAgregarEditar();
                TabControl.SelectTab("TabPageLista");
            }
            else
            {
                MessageBox.Show("Error al agregar el pais", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //checheamos que haya pais seleccionadas
            if (GridPaises.RowCount > 0 && GridPaises.SelectedRows.Count > 0)
            {
                paisCurrent = (Pais)GridPaises.SelectedRows[0].DataBoundItem;
                TxtNombre.Text = paisCurrent.Nombre;
                TabControl.SelectTab("TabPageAgregarEditar");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridPaises.DataSource = paises.Where(p => p.Nombre.ToUpper().Contains(TxtBuscar.Text.ToUpper()))
                .ToList();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
                BtnBuscar.PerformClick();
        }

        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            LabelStatusMessage.Text = string.Empty;
            TimerStatusBar.Stop(); // Detener el temporizador después de mostrar el mensaje
        }
    }
}
