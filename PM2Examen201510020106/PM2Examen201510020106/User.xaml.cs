
using PM2Examen201510020106.Model;
using SQLite;
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
    public partial class User : ContentPage
    {
        public User()
        {
            InitializeComponent();
        }


        private void btnSalvar_Clicked(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                DisplayAlert("Alerta", "Debe ingresar Usuario", "Ok");
            }
            else
            {
                Int32 resultado = 0;
                var ubicacion = new User()
                {
                    
                    
                };
                using (SQLiteConnection conexion = new SQLiteConnection(App.UbicacionDB))
                {
                    conexion.CreateTable<User>();
                    resultado = conexion.Insert(ubicacion);

                    if (resultado > 0)
                    {
                        DisplayAlert("Aviso", "Adicionado", "Ok");
                        txtUser.Text = "";
                        txtPassword.Text = "";
                    }
                    else
                    {
                        DisplayAlert("Aviso", "Error", "Ok");
                    }
                }
            }
        }
    }
}