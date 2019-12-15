using PosApp.Admin;
using PosApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PosApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        UserService userService;
        public MainPage()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var username = Username.Text;
            var password = Password.Text;
            var role = userService.getUser(username, password);

            if (!String.IsNullOrEmpty(role))
            {
                var dashboard = new Admin.Admin();
                await Navigation.PushAsync(dashboard);
            }
            else
            {
                await DisplayAlert("Sorry", "User doesn't exist", "OK");
            }
        }
    }
}
