using Bicicrack.Services;
using Bicicrack.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bicicrack
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
