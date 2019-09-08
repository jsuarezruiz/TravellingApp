using TravellingApp.ViewModels;
using Xamarin.Forms;

namespace TravellingApp.Views
{
    public partial class ShopView : ContentPage
    {
        public ShopView()
        {
            InitializeComponent();
            BindingContext = new ShopViewModel();
        }
    }
}