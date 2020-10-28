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
                img = new Image { Source = "Jeep.png" },
                new Rectangle(180, 250, 200, 200)
            );
            Content = absoluteLayout;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Больше", "Происхождение слова «джип» вызывает много споров." +
                " По наиболее распространённой версии, оно возникло от сокращения GPW (аббревиатура компании Ford Motor, расшифровывалась: G — государственный заказ, Р — автомобиль с колёсной базой до 80 дюймов, W — тип Willys, так как автомобиль выпускался компанией Ford Motor по технической документации фирмы Willys согласно мобилизационному договору с правительством США от 10 января 1941 года).", "Понятно");
        }
        private void Btn2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("История", "Создателем первого автомобиля Jeep является американский инженер Карл Пробст, сконструировавший в июле 1940 года на фирме American Bantam в рамках тендера американской армии полноприводный автомобиль Bantam BRC грузоподъёмностью «четверть тонны» с открытым кузовом типа Ранебаут." +
                " Данная конструкция была потом по настоянию армии доработана более крупными фирмами Willys-Overland и Ford Motor Co., в результате и получившими основные заказы на поставку Jeep Willys MB и Ford GPW армиям США и их союзников." +
                " До конца Второй мировой войны их было выпущено 361,4 и 277,9 тыс. ед., соответственно." +
                " Значительные поставки данных однотипных моделей осуществлялись и в СССР, куда в рамках программы ленд-лиза было отправлено свыше 51 тыс. единиц Willys в собранном и разобранном виде." +
                " Неформальное прозвище Jeep было(есть мнение что данное название марка получила от автомобиля Ford GPW в частности из за фонетического сочетания первых букв аббревиатуры названия Джи Пи) запущено в широкое обращение американской журналисткой Катариной Хилльер весной 1941 года после испытаний автомобиля Bantam." +
                " Оно стало торговой маркой фирмы Willys - Overland в 1945 году." +
                " После окончания войны Willys Overland решила приспособить своё детище к выполнению некоторых гражданских функций." +
                " Была подготовлена партия машин." +
                " Назвали их просто — CJ(аббревиатура от Civilian Jeep — «гражданский джип»)." +
                " Эти прототипы послужили базой для создания серийной модели, которая поступила в продажу в августе 1945 года." +
                " Внешне вся «гражданственность» заключалась в наличии откидываемого заднего борта, дворников и крышки бензобака на заднем крыле." +
                " На капоте, задней дверце и раме стекла должен был быть логотип Jeep." +
                " Однако в первые годы производства, когда компания ещё вела судебные разбирательства с «Американ Бантам Кар» о праве использования названия Jeep машины приходилось изготавливать с логотипом Willys." +
                " Но уже в 1950 году компания добилась закрепления за собой этого имени, и 13 июня 1950 года Jeep был зарегистрирован в качестве торговой марки.", "Понятно");
        }
    }
}