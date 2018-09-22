using System;
using ChatMatch.Core.Views;
using ChatMatch.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ChatMatch {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            RootMasterDetailPage rootMasterDetailPage = new RootMasterDetailPage(new SideMenuContentPage(), new BaseNavigationPage(new HomeContentPage()));
            MainPage = rootMasterDetailPage;

        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}
