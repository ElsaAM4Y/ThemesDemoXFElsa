using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThemesDemoXFElsa.Themes;
using ThemesDemoXFElsa.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThemesDemoXFElsa.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            themePicker.SelectedIndexChanged += ThemePicker_SelectedIndexChanged;
            this.BindingContext = new LoginViewModel();
        }

        private void ThemePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemeManager.ChangeTheme(themePicker.SelectedItem.ToString());
        }
    }
}