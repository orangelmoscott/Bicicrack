using Bicicrack.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Bicicrack.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}