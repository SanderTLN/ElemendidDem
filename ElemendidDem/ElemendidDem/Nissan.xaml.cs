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
    public partial class Nissan : ContentPage
    {
        Button btn1, btn2;
        public Nissan()
        {
            BackgroundColor = Color.Wheat;
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "Nissan", FontSize = 30, TextColor = Color.Black },
                new Rectangle(100, 20, 250, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Nissan Motor Co., Ltd. — японский автопроизводитель, один из крупнейших в мире.", FontSize = 20, TextColor = Color.Black },
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
                img = new Image { Source = "Nissan.png" },
                new Rectangle(180, 250, 200, 200)
            );
            Content = absoluteLayout;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Больше", "Компания основана в 1933 году." +
                " По состоянию на 2010 год занимает 8-е место в мировом рейтинге автопроизводителей (3-е среди японских производителей, после Toyota и Honda) по версии международного института исследования рынка IHS Automotive." +
                " Штаб-квартира находится в городе Иокогама.", "Понятно");
        }
        private void Btn2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("История", "Датой основания корпорации считается 26 декабря 1933 года, когда в результате слияния компаний «Тобата имоно» и «Нихон сангё» была создана новая компания, которая с 1 июня 1934 года носит название «Ниссан мотор» (по первым буквам названия компании «Нихон сангё» — «японская промышленность»)." +
                " В мае 1935 года компания приняла решение о развитии торговой марки «Ниссан», но практически до 1980 - х годов лицом компании были различные модификации автомобилей «Datsun», выпускавшихся ещё до создания компании(в 1986 году эта марка перестала существовать, а в 2013 году производство автомобилей Datsun было возобновлено)." +
                " С начала 1950 - х годов компания активно и успешно стала заниматься разработкой и производством ракетных двигателей, установок для запуска ракет, а затем решила расширить производственную сферу, занявшись также и производством двигателей для кораблестроительной отрасли." +
                " В 1958 году начались поставки автомобилей в США, а в 1964 году стала первой японской компанией, вошедшей в десятку крупнейших автоимпортёров в США." +
                " В 1962 году начались поставки автомобилей в Европу." +
                " Первое зарубежное сборочное производство Nissan было открыто в 1959 году на Тайване, по состоянию на 2010 - е годы зарубежное производство развёрнуто в 20 странах." +
                " В 1976 году, благодаря собственному флоту, Nissan стал крупнейшим экспортёром автомобилей в мире, а в следующем году совокупное количество проданных автомобилей(за все годы функционирования) перешагнуло 20 миллионов." +
                " В 1981 году корпорация подписала соглашение с Volkswagen о производстве и продаже легковых автомобилей в Японии." +
                " В 1992 году на долю Ниссана приходилось 17 % автомобилей, принадлежащих японскому населению.", "Понятно");
        }
    }
}