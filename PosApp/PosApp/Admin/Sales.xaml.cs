using PosApp.Model;
using PosApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PosApp.Admin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sales : ContentPage
    {
        SaleService SaleService;
        public Sales()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadData();
        }

        async Task LoadData()
        {
            await Task.Factory.StartNew(()=>
            {
                SaleService = new SaleService();
                BindingContext = SaleService;
            });
        }
    }
}