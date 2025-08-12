using WindowsForms.Views;

namespace WindowsForms
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void SubMenuSalirDelSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmenuAppClima_Click(object sender, EventArgs e)
        {
            var appClimaView = new ClimaAppView();
            appClimaView.ShowDialog();
        }

        private void SubmenuFormularioFuentes_Click(object sender, EventArgs e)
        {
            var fuentesView = new FuentesView();
            fuentesView.ShowDialog();
        }

        private void SubmenuFormPeliculasApi_Click(object sender, EventArgs e)
        {
            var peliculasView = new PeliculasView();
            peliculasView.ShowDialog();
        }

        private void SubmenuFormPeliculasADO_Click(object sender, EventArgs e)
        {
            var peliculasADOView = new PeliculasADOView();
            peliculasADOView.ShowDialog();
        }

        private void subMenuPeliculaEF_Click(object sender, EventArgs e)
        {
            var peliculasEFView = new PeliculasEFView();
            peliculasEFView.ShowDialog();
        }

        private void SubMenuPaisesEF_Click(object sender, EventArgs e)
        {
            PaisesEFView paisesEFView = new PaisesEFView();
            paisesEFView.ShowDialog();
        }

        private void SubMenuActores_Click(object sender, EventArgs e)
        {
            var actoresView = new Actores();
            actoresView.ShowDialog();
        }

        private void SubMenuCine_Click(object sender, EventArgs e)
        {
            var cineView = new Cine();
            cineView.ShowDialog();
        }
    }
}
