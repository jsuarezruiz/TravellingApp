using TravellingApp.ViewModels;
using Xamarin.Forms;

namespace TravellingApp.Views
{
    public partial class BagView : ContentPage
    {
        public BagView()
        {
            InitializeComponent();
            BindingContext = new BagViewModel();
        }
    }
}