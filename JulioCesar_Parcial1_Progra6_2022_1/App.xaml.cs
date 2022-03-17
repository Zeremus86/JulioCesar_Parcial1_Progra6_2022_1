using JulioCesar_Parcial1_Progra6_2022_1.Services;
using JulioCesar_Parcial1_Progra6_2022_1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JulioCesar_Parcial1_Progra6_2022_1
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
