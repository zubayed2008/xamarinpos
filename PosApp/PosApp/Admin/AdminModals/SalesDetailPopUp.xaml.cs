using PosApp.Model;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PosApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SalesDetailPopUp : PopupPage
    {
        public SalesDetailPopUp(AnimalModel animalModal)
        {
            InitializeComponent();
            name.Text = "Name: " + animalModal.Name;
            location.Text = "Location: " + animalModal.Location;
            details.Text = "Details: " + animalModal.Details;
            date.Text = "Date: "+ animalModal.Date;
            price.Text ="Price: " + animalModal.Price;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync(true);
        }
    }
}