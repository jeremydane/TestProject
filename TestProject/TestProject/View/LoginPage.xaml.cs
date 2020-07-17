using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestProject.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            init();
        }

        void init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lb1_username.TextColor = Constants.MainTextColor;
            Lb2_password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;

            Entry_username.Completed += (s, e)=>Entry_password.Focus();
            Entry_password.Completed += (s, e)=>Btn_signIn_Clicked(s,e);
        }

        async void Btn_signIn_Clicked(object sender, EventArgs e)
        {
            User user = new User(Entry_username.Text, Entry_password.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login","Login Sucess","Ok");
                var result = await App.RestService.Login(user);
                if (result.access_token != null)
                {
                    App.UserDatabase.SaveUser(user);
                }                
            }
            else
            {
                DisplayAlert("Login", "Login Failed, empty username or password", "Ok");
            }


        }
    }
}