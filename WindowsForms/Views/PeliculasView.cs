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
    public partial class PeliculasView : Form
    {
        HttpClient clientHttp = new HttpClient();
        string url = "https://practprof2023-2855.restdb.io/rest/movies?apikey=5ef3666c6a76415a50ddab26a474d3a68c6b4";
        PeliculaService peliculaService = new PeliculaService();
        Pelicula peliculaModificada;
        List<Pelicula>? peliculas;

        public PeliculasView()
        {
            InitializeComponent();
            ObtenemosPeliculas();
        }

        private async void ObtenemosPeliculas()
        {
            peliculas = await peliculaService.GetAllAsync();
            GridPeliculas.DataSource = peliculas;
        }

        private void GridPeliculas_SelectionChanged_1(object sender, EventArgs e)
        {
            if (GridPeliculas.RowCount > 0 && GridPeliculas.SelectedRows.Count > 0)
            {
                Pelicula peliSeleccionada = (Pelicula)GridPeliculas.SelectedRows[0].DataBoundItem;
                FilmPicture.ImageLocation = peliSeleccionada.portada;
            }
        }

        private async void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
            if (GridPeliculas.RowCount > 0 && GridPeliculas.SelectedRows.Count > 0)
            {
                Pelicula peliSeleccionada = (Pelicula)GridPeliculas.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea eliminar la pelicula {peliSeleccionada.titulo}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await peliculaService.DeleteAsync(peliSeleccionada._id))
                    {
                        LabelStatusMessage.Text = $"Pelicula {peliSeleccionada.titulo} eliminada correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        ObtenemosPeliculas();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            TxtTitulo.Clear();
            NumericDuracion.Value = 0;
            TxtPortada.Clear();
            NumericCalificacion.Value = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageLista");

        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            Pelicula peliculaAGuardar = new Pelicula
            {
                _id = peliculaModificada?._id??null, 
                titulo = TxtTitulo.Text,
                duracion = (int)NumericDuracion.Value,
                portada = TxtPortada.Text,
                calificacion = (double)NumericCalificacion.Value
            };

            bool response;
            if (peliculaModificada != null)
            {
                response=await peliculaService.UpdateAsync(peliculaAGuardar);
            }
            else
            {
                response = await peliculaService.AddAsync(peliculaAGuardar);
            }
            if (response)
            {
                peliculaModificada = null; // Reset the modified movie after saving
                LabelStatusMessage.Text = "Pelicula guardada correctamente";
                TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                ObtenemosPeliculas();
                LimpiarControlesAgregarEditar();
                TabControl.SelectTab("TabPageLista");
            }
            else
            {
                MessageBox.Show("Error al agregar la pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
            if (GridPeliculas.RowCount > 0 && GridPeliculas.SelectedRows.Count > 0)
            {
                peliculaModificada = (Pelicula)GridPeliculas.SelectedRows[0].DataBoundItem;
                TxtTitulo.Text = peliculaModificada.titulo;
                NumericDuracion.Value = peliculaModificada.duracion;
                TxtPortada.Text = peliculaModificada.portada;
                NumericCalificacion.Value = (decimal)peliculaModificada.calificacion;
                TabControl.SelectTab("TabPageAgregarEditar");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridPeliculas.DataSource = peliculas.Where(p => p.titulo.ToUpper().Contains(TxtBuscar.Text.ToUpper()))
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
