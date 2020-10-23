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
    public partial class Jeep : ContentPage
    {
        Button btn1, btn2;
        public Jeep()
        {
            BackgroundColor = Color.Wheat;
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "Jeep", FontSize = 30, TextColor = Color.Black },
                new Rectangle(175, 20, 100, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Jeep — марка автомобилей, производимых итало-американской компанией Fiat Chrysler Automobiles.", FontSize = 20, TextColor = Color.Black },
                new Rectangle(20, 80, 390, 120)
            );
            absoluteLayout.Children.Add(
                btn1 = new Button { Text = "Больше", FontSize = 20, BackgroundColor = Color.FromHex("#3366FF") },
                new Rectangle(20, 300, 120, 50)
            );
            btn1.Clicked += Btn1_Clicked; ;
            absoluteLayout.Children.Add(
                btn2 = new Button { Text = "История", FontSize = 20, BackgroundColor = Color.FromHex("#3366FF") },
                new Rectangle(20, 400, 120, 50)
            );
            btn2.Clicked += Btn2_Clicked;
            Content = absoluteLayout;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Больше", "", "Понятно");
        }
        private void Btn2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("История", "", "Понятно");
        }
    }
}