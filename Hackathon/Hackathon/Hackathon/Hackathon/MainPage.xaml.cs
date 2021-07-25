using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hackathon
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Walk.Text = WebReq("steps", 55, 3) + " steps";

            Calories.Text =  WebReq("calories", 58, 3) + " calories";

            Floors.Text = WebReq("floors", 56, 1) + " floor";

            Dis.Text = WebReq("tracker/distance", 66, 4) + " km";

            HeartRate.Text = WebReq("heart", 128, 2) + " bpm";

            nav();
        }

        public async void nav()
        {
            var go = new TapGestureRecognizer();
            go.Tapped += async (s, e) =>
            {
                await Navigation.PushAsync(new Survey());
            };

            GO.GestureRecognizers.Add(go);
        }

        public string WebReq(string act, int start, int end)
        {
            string access_token = "eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIyM0I3UzQiLCJzdWIiOiI2NUhCNjciLCJpc3MiOiJGaXRiaXQiLCJ0eXAiOiJhY2Nlc3NfdG9rZW4iLCJzY29wZXMiOiJyc29jIHJhY3QgcnNldCBybG9jIHJ3ZWkgcmhyIHJwcm8gcm51dCByc2xlIiwiZXhwIjoxNjI3NjgwOTg0LCJpYXQiOjE2MjcxNzE4OTB9.umn43dNidp-S2J5XHKSk_Kf_0z8BcIFeiSWBeMnPpzY";
            string user_id = "65HB67";

            string work = "https://api.fitbit.com/1/user/"
                + user_id +
                "/activities/" + act + "/date/today/today.json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(work);
            request.Method = "GET";
            request.Headers["Authorization"] = "Bearer " + access_token;
            request.Accept = "application/json";

            WebResponse myResponse;

            myResponse = request.GetResponse();

            string result = "";

            StreamReader httpwebStreamReader = new StreamReader(myResponse.GetResponseStream());
            result = httpwebStreamReader.ReadToEnd();

            myResponse.Close();
            httpwebStreamReader.Close();

            Console.WriteLine("HIIIII" + result);

            return result.Substring(start, end);
        }
    }
}
