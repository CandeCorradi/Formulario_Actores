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
    public partial class ActorEFView : Form
    {
        //instanciamos el servicio
        ActorEFService actorEFService = new ActorEFService();
        Actor actorCurrent;
        List<Actor>? actores;

        public ActorEFView()
        {
            InitializeComponent();
            ObtenemosActores();
        }
        private async void ObtenemosActores()
        {
            actores = await actorEFService.GetAllAsync();
            GridActores.DataSource = actores;
            GridActores.Columns["Id"].Visible = false; // Ocultamos la columna Pais
            GridActores.Columns["Eliminado"].Visible = false; // Ocultamos la columna Eliminado
        }
        private async void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
            if (GridActores.RowCount > 0 && GridActores.SelectedRows.Count > 0)
            {
                Actor actorSelected = (Actor)GridActores.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea eliminar el actor {actorSelected.Nombre}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await actorEFService.DeleteAsync(actorSelected.Id))
                    {
                        LabelStatusMessage.Text = $"¿Seguro que desea eliminar el actor  {actorSelected.Nombre} eliminado correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        ObtenemosActores();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el actor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un actor para eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Actor actorToSave = new Actor
            {
                Id = actorCurrent?.Id ?? 0, 
                Nombre = TxtNombre.Text
            };

            bool response;
            if (actorCurrent!= null)
            {
                response=await actorEFService.UpdateAsync(actorToSave);
            }
            else
            {
                response = await actorEFService.AddAsync(actorToSave);
            }
            if (response)
            {
                actorCurrent = null; // Reset the modified movie after saving
                LabelStatusMessage.Text = "Actor guardado correctamente";
                TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                ObtenemosActores();
                LimpiarControlesAgregarEditar();
                TabControl.SelectTab("TabPageLista");
            }
            else
            {
                MessageBox.Show("Error al agregar el actor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //checheamos que haya actor seleccionadas
            if (GridActores.RowCount > 0 && GridActores.SelectedRows.Count > 0)
            {
                actorCurrent = (Actor)GridActores.SelectedRows[0].DataBoundItem;
                TxtNombre.Text = actorCurrent.Nombre;
                TabControl.SelectTab("TabPageAgregarEditar");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridActores.DataSource = Actor.Where(p => p.Nombre.ToUpper().Contains(TxtBuscar.Text.ToUpper()))
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
