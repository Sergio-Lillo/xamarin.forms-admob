using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AdmobTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.C_sharp.AnuncioPagina();
            //MainPage = new Views.XAML.AnuncioPagina();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
