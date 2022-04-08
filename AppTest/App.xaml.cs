using AppTest.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTest
{
    public partial class App : Application
    {
        public static AdressViewModel AdressModel { get; set; } = new AdressViewModel();
        public App()
        {
            InitializeComponent();

            //App.AdressModel.AdressObj = new Model.Adress { ip = "123", country = "Sweden" };
            //AdressModel.loadAdress();

            MainPage = new MainPage();
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
