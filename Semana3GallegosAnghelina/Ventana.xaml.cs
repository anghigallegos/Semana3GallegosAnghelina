using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3GallegosAnghelina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ventana : ContentPage
    {
        public Ventana()
        {
            InitializeComponent();
            lbUser.Text = user;
            txtPass.Text = pass;

        }
    }
}