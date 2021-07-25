using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Web;
using System.Net.Http;
using System.Net;

namespace Hackathon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_Pressed(object sender, EventArgs e)
        {
            await Browser.OpenAsync(new Uri("https://www.fitbit.com/oauth2/authorize?response_type=token&client_id=23B7S4&redirect_uri=http://127.0.0.1:8080/&scope=activity%20nutrition%20heartrate%20location%20nutrition%20profile%20settings%20sleep%20social%20weight&expires_in=604800"), BrowserLaunchMode.SystemPreferred);
            await Navigation.PushAsync(new MainPage());
        }
    }
}