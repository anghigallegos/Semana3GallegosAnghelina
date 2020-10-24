using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3GallegosAnghelina
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //habiliat navegacion
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
