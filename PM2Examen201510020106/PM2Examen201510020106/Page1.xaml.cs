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
    public partial class Page1 : ContentPage
    {
        public Page1(int i , string n)
        {
            InitializeComponent();
            id.Text = i.ToString();
            nombre.Text = n;
        }
        private void Eliminar_Clicked(object sender, EventArgs e)
        {
            int idu = int.Parse(id.Text);
            Int32 resultado = 0;
            using (SQLiteConnection conexion = new SQLiteConnection(App.UbicacionDB))
            {
                resultado = conexion.Execute("delete from ubicacion where id=" + idu + "");
                DisplayAlert("Aviso", "Datos Eliminado", "Ok");
            }
        }

        private void Modificar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Aviso", "Datos Modificados", "Ok");
        }
    }
}