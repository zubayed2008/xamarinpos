﻿using PosApp.Admin;
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
            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            imageSource.CachingEnabled = true;
            imageSource.CacheValidity = TimeSpan.FromHours(1);
            imagesrc.Source = imageSource;
            userService = new UserService();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //var username = Username.Text;
            //var password = Password.Text;
            //var role = userService.getUser(username, password);
            //if (!String.IsNullOrEmpty(role))
            //{
                var sales = new Sales();
                Navigation.PushModalAsync(sales);
            //}
            //else
            //{
            //    DisplayAlert("Sorry", "User doesn't exist", "OK");
            //}
        }
    }
}