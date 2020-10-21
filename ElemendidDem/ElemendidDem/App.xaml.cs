using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ElemendidDem.Services;
using ElemendidDem.Views;

namespace ElemendidDem
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new ElemendidDem.MainPage());
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
