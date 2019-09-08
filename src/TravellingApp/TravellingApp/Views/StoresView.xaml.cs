using TravellingApp.ViewModels;
using Xamarin.Forms;

namespace TravellingApp.Views
{
    public partial class StoresView : ContentPage
    {
        public StoresView()
        {
            InitializeComponent();
            BindingContext = new StoresViewModel();
        }
    }
}