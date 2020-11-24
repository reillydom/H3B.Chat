using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace H3B.Chat
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.LoginView();
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
