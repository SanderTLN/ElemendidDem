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
                new Rectangle(20, 80, 350, 180)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Логотип", FontSize = 30, TextColor = Color.Black },
                new Rectangle(220, 400, 120, 60)
            );
            absoluteLayout.Children.Add(
                btn1 = new Button { Text = "Больше", FontSize = 20, BackgroundColor = Color.FromHex("#3366FF") },
                new Rectangle(20, 300, 120, 50)
            );
            btn1.Clicked += Btn1_Clicked;
            absoluteLayout.Children.Add(
                btn2 = new Button { Text = "История", FontSize = 20, BackgroundColor = Color.FromHex("#3366FF") },
                new Rectangle(20, 400, 120, 50)
            );
            btn2.Clicked += Btn2_Clicked;
            Image img;
            absoluteLayout.Children.Add(
                img = new Image { Source = "BMW.png" },
                new Rectangle(180, 250, 200, 200)
            );
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
            DisplayAlert("История", "Промышленная фирма была основана Карлом Фридрихом Раппом в октябре 1916 года, официально компания BMW была зарегистрирована 20 июля 1917 года, но первоначально — как производитель авиационных двигателей, Bayerische Flugzeug-Werke." +
                " Округ Мюнхена — Milbertshofen был выбран потому, что он располагался близко от Flugmaschinenfabrik Густава Отто — немецкого производителя самолётов." +
                " В 1916 году компания подписывает контракт на производство двигателей V12 для Австро - Венгрии." +
                " Нуждаясь в дополнительном финансировании, Рапп получает поддержку Камилло Кастильони и Макса Фрица, компания воссоздаётся как Bayerische Motoren Werke GmbH." +
                " Быстрый рост предприятия в 1917 году вызвал некоторые трудности, после чего компанию покинул Рапп, руководство перешло к австрийскому промышленнику Францу Йозефу Поппу, а в 1918 году компания была переименована в BMW AG." +
                " С 1929 года бело - голубая круглая эмблема BMW, использующаяся и до сих пор(показана справа вверху), для удобства начинает трактоваться как самолётный винт на фоне голубого неба." +
                " Компания BMW утверждает, что белый и голубой цвета на логотипе взяты из флага Баварии", "Понятно");
        }
    }
}