using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace SafeIn_Door
{
    public partial class App : Application
    {
        public static string Door_id { get; set; }
        public static string BaseUrl = "https://safeinapisecondaccount.azurewebsites.net/";

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
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
