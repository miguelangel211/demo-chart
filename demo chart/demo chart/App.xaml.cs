using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace demo_chart
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDgxMDZAMzEzNjJlMzMyZTMwRTFrUmNpL2lBOUhnQmhLSXc3MHpkdU5ONHpTVTR0d3pVeklBVjlCWUV5bz0=");
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Toast.MakeText(this, "Procedimento de logon ", ToastLength.Long).Show();

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
