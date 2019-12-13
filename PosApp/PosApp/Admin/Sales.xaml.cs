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
        public Sales()
        {
            InitializeComponent();
            BindingContext = new SaleService();
            

        }
    }
}