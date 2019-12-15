using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PosApp.Admin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminMaster : ContentPage
    {
        public ListView ListView;

        public AdminMaster()
        {
            InitializeComponent();

            BindingContext = new AdminMasterViewModel();
            ListView = MenuItemsListView;
        }

        class AdminMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<AdminMasterMenuItem> MenuItems { get; set; }

            public AdminMasterViewModel()
            {
                MenuItems = new ObservableCollection<AdminMasterMenuItem>(new[]
                {
                    new AdminMasterMenuItem { Id = 0, Title="Home", Icon="home.png", TargetType = typeof(Admin)},
                    new AdminMasterMenuItem { Id = 1, Title = "Checkout", Icon="checkout.png"},
                    new AdminMasterMenuItem { Id = 2, Title = "Sales Report", TargetType = typeof(Sales), Icon="salesreport.png" },
                    new AdminMasterMenuItem { Id = 3, Title = "Products", Icon="products.png" },
                    new AdminMasterMenuItem { Id = 4, Title = "Inventory", Icon="inventory.png" },
                });

            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}