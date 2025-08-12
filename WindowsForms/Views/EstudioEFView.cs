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
    public partial class EstudioEFView : Form
    {
        //instanciamos el servicio
        EstudioEFService estudioEFService = new EstudioEFService();
        Estudio estudioCurrent;
        List<Estudio>? estudios;

        public EstudioEFView()
        {
            InitializeComponent();
            ObtenemosEstudios();
        }
        private async void ObtenemosEstudios()
        {
            estudios = await estudioEFService.GetAllAsync();
            GridEstudios.DataSource = estudios;
            GridEstudios.Columns["Id"].Visible = false; // Ocultamos la columna Pais
            GridEstudios.Columns["Eliminado"].Visible = false; // Ocultamos la columna Eliminado
        }
        private async void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
            if (GridEstudios.RowCount > 0 && GridEstudios.SelectedRows.Count > 0)
            {
                Estudio estudioSelected = (Estudio)GridEstudios.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea eliminar el estudio {estudioSelected.Nombre}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await estudioEFService.DeleteAsync(estudioSelected.Id))
                    {
                        LabelStatusMessage.Text = $"Estudio {estudioSelected.Nombre} eliminado correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        ObtenemosEstudios();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el estudio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un estudio para eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Estudio estudioToSave = new Estudio
            {
                Id = estudioCurrent?.Id ?? 0, 
                Nombre = TxtNombre.Text
            };

            bool response;
            if (estudioCurrent!= null)
            {
                response=await estudioEFService.UpdateAsync(estudioToSave);
            }
            else
            {
                response = await estudioEFService.AddAsync(estudioToSave);
            }
            if (response)
            {
                estudioCurrent = null; // Reset the modified movie after saving
                LabelStatusMessage.Text = "Estudio guardado correctamente";
                TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                ObtenemosEstudios();
                LimpiarControlesAgregarEditar();
                TabControl.SelectTab("TabPageLista");
            }
            else
            {
                MessageBox.Show("Error al agregar el estudio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //checheamos que haya pais seleccionadas
            if (GridEstudios.RowCount > 0 && GridEstudios.SelectedRows.Count > 0)
            {
                estudioCurrent = (Estudio)GridEstudios.SelectedRows[0].DataBoundItem;
                TxtNombre.Text = estudioCurrent.Nombre;
                TabControl.SelectTab("TabPageAgregarEditar");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridEstudios.DataSource = estudios.Where(p => p.Nombre.ToUpper().Contains(TxtBuscar.Text.ToUpper()))
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
