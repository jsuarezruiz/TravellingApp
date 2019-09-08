using TravellingApp.ViewModels;
using Xamarin.Forms;

namespace TravellingApp.Views
{
    public partial class CommunityView : ContentPage
    {
        public CommunityView()
        {
            InitializeComponent();
            BindingContext = new CommunityViewModel();
        }
    }
}