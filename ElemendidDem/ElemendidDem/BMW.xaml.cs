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
    public partial class BMW : ContentPage
    {
        Button btn1, btn2;
        public BMW()
        { 
            BackgroundColor = Color.Wheat;
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "BMW", FontSize = 30, TextColor = Color.Black },
                new Rectangle(175, 20, 100, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "BMW AG (аббревиатура от Bayerische Motoren Werke AG, с нем. — «Баварские моторные заводы») — немецкий производитель автомобилей, мотоциклов, двигателей, а также велосипедов.", FontSize = 20, TextColor = Color.Black },
                new Rectangle(20, 80, 400, 120)
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
            DisplayAlert("Больше", "Председателем компании с 2006 по 2015 год был Норберт Райтхофер, с мая 2015 года — Харальд Крюгер, а с 18 июля 2019 года — Оливер Ципсе." +
                " Главный дизайнер — Йозеф Кабан. Девиз компании — «Freude am Fahren», с нем. — «С удовольствием за рулём»." +
                " Для англоязычных стран был придуман также девиз «The Ultimate Driving Machine» (с англ. — «Идеальная машина для вождения»).", "Понятно");
        }
        private void Btn2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("История", "", "Понятно");
        }
    }
}