using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2Examen201510020106
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            String sUsuario = txtUsuario.Text;
            String sPassword = txtPassword.Text;

            if ((sUsuario == "Admin") && (sPassword == "1234"))
            {
                _ = Navigation.PushAsync(new DashBoard());
            }
            else
            {
                await DisplayAlert("Error", "Usuario Incorrecto", "Ok");
            }
        }

        private void Salir_Clicked(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}