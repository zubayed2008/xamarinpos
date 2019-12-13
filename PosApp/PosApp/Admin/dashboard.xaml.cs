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
	public partial class Dashboard : ContentPage
	{
        bool tapped = true;
		public Dashboard ()
		{
			InitializeComponent ();
            tapped = true;
		}

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (tapped)
            {
                tapped = false;
                var sales = new Sales();
                await Navigation.PushModalAsync(sales);
                tapped = true;
            }

        }
    }
}