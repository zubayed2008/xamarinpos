using PosApp.Model;
using PosApp.Services;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
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
        public Sales()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
             LoadData();
        }

        void LoadData()
        {
            try
            {
                this.BindingContext = new SaleService();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private  void  TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var s = sender as Label;
            //Navigation.PushPopupAsync(new Testpopup(),true);
        }
    }
}