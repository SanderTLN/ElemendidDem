using System.ComponentModel;
using Xamarin.Forms;
using ElemendidDem.ViewModels;

namespace ElemendidDem.Views
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