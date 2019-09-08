using TravellingApp.ViewModels;
using Xamarin.Forms;

namespace TravellingApp.Views
{
    public partial class MeView : ContentPage
    {
        public MeView()
        {
            InitializeComponent();
            BindingContext = new MeViewModel();
        }
    }
}