using MiPrimeraApp01.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MiPrimeraApp01.Views
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