using AppNetMaui.Views;

namespace AppNetMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PeliculasView();
        }
    }
}
