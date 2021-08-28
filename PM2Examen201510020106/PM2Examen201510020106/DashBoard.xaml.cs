
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
    public partial class DashBoard : ContentPage
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btnmapas_Clicked(object sender, EventArgs e)
        {

        }

        private void btnsalvado_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Lista());
        }

        private void btnSalvar_Clicked(object sender, EventArgs e)
        {
            if (txtLatitud.Text == "")
            {
                DisplayAlert("Alerta", "Debe ingresar Latitud", "Ok");
            }
            else
            {
                Int32 resultado = 0;
                var ubicacion = new Ubicacion()
                {
                    Latitud = txtLatitud.Text,
                    Longitud = txtLongitud.Text,
                    Descripcion = txtDescripcion.Text,
                    DescripcionCorta = txtDescripcionCorta.Text
                };
                using (SQLiteConnection conexion = new SQLiteConnection(App.UbicacionDB))
                {
                    conexion.CreateTable<Ubicacion>();
                    resultado = conexion.Insert(ubicacion);

                    if (resultado > 0)
                    {
                        DisplayAlert("Aviso", "Adicionado", "Ok");
                        txtLatitud.Text = "";
                        txtDescripcion.Text = "";
                        txtDescripcionCorta.Text = "";
                        txtLongitud.Text = "";
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