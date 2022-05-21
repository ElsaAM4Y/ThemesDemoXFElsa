using ThemesDemoXFElsa.Themes;
using ThemesDemoXFElsa.Views;
using Xamarin.Forms;

namespace ThemesDemoXFElsa
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            ThemeManager.ChangeTheme("LightTheme"); //Initialize the Default Theme
            MainPage = new LoginPage();
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
