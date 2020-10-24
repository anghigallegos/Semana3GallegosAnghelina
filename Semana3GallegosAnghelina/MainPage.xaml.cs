using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana3GallegosAnghelina
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;

            string user_val = "uisrael";
            string pass_val = "uisrael2020";

            await Navigation.PushAsync(new Ventana(user, pass));

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}
