using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2Examen201510020106
{
    public partial class App : Application
    {
        public static string UbicacionDB = string.Empty;
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Login());
            
        }
        public App(string DBlocal)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());

            UbicacionDB = DBlocal;
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
