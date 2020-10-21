using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElemendidDem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Audi : ContentPage
    {
        public Audi()
        {
            BackgroundColor = Color.Wheat;
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "Audi", FontSize = 30, TextColor = Color.Black },
                new Rectangle(175, 20, 100, 60)
            );
            Content = absoluteLayout;
        }
    }
}