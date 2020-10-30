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
    public partial class Porsche : ContentPage
    {
        Button btn1, btn2, btn3;
        public Porsche()
        {
            BackgroundColor = Color.Wheat;
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "Porsche", FontSize = 30, TextColor = Color.Black },
                new Rectangle(150, 20, 250, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Porsche AG — немецкий производитель автомобилей и солнцезащитных очков, основанный известным конструктором Фердинандом Порше в 1931 году.", FontSize = 20, TextColor = Color.Black },
                new Rectangle(20, 80, 300, 180)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Логотип", FontSize = 30, TextColor = Color.Black },
                new Rectangle(220, 420, 120, 60)
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
            absoluteLayout.Children.Add(
                btn3 = new Button { Text = "Актёр", FontSize = 20, BackgroundColor = Color.FromHex("#3366FF") },
                new Rectangle(20, 500, 120, 50)
            );
            btn3.Clicked += Btn3_Clicked;
            Image img;
            absoluteLayout.Children.Add(
                img = new Image { Source = "Porsche.png" },
                new Rectangle(180, 250, 200, 200)
            );
            Content = absoluteLayout;
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("30 ноября 2013 года", "Porsche Carrera GT - именно в этом автомобиле погиб известный актёр Пол Уокер, наиболее известный по серии фильмов «Форсаж» в роли: Брайана О'Коннора." +
                " Друг актера разогнал свой спорткар Porsche Carrera GT, в котором на пассажирском сиденье был Уокер, до 130–150 км/ч и не справился с управлением." +
                " От машины почти ничего не осталось, а Пол Уокер и его друг Роджер Родас мгновенно умерли на месте.", "Понятно");
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Больше", "Штаб-квартира и основной завод находится в Штутгарте, Германия." +
                " Основным акционером компании является род Порше." +
                " Porsche является самой высокодоходной автомобильной компанией в мире (в пересчёте на прибыль от каждой проданной машины)." +
                " В 2010 году автомобили Porsche были признаны самыми надёжными в мире." +
                " В России подразделение Porsche возглавляет доктор Томас Штэрцель.", "Понятно");
        }
        private void Btn2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("История", "К моменту выпуска первого автомобиля под своим именем Фердинанд Порше успел накопить немалый опыт." +
                " Основанное им 25 апреля 1931 года предприятие Dr. Ing. h.c. F. Porsche GmbH под его началом уже успело поработать над такими проектами, как 6-цилиндровый гоночный Auto Union и Volkswagen Käfer, ставший одним из самых продаваемых автомобилей в истории." +
                " В 1939 году был разработан первый автомобиль компании — Porsche 64, который стал прародителем всех будущих Porsche." +
                " Для постройки этого экземпляра Фердинанд Порше использовал многие компоненты от Volkswagen Käfer." +
                " В течение Второй Мировой компания занималась выпуском военной продукции — штабных автомобилей и амфибий." +
                " Фердинанд Порше принимал участие в разработке немецких тяжёлых танков «Тигр P», а также сверхтяжёлого танка «Маус»." +
                " В декабре 1945 года он был арестован по обвинению в военных преступлениях и помещён в тюрьму, где провёл 20 месяцев." +
                " В то же время его сын Фердинанд(краткое имя Ферри) Антон Эрнст решил начать выпуск собственных автомобилей." +
                " Гмюнде Ферри Порше вместе с несколькими знакомыми инженерами собрал прототип 356 - го с мотором в базе и алюминиевым открытым кузовом и начал подготовку к его серийному производству." +
                " В июне 1948 года этот экземпляр был сертифицирован для дорог общего пользования.Как и 9 лет назад, тут вновь были использованы агрегаты от Volkswagen Käfer, включая 4 - цилиндровый мотор воздушного охлаждения, подвеску и коробку передач." +
                " У первых серийных машин было принципиальное отличие — двигатель перенесли за заднюю ось, что позволило удешевить производство и освободить пространство для двух дополнительных мест в салоне." +
                " Спроектированный кузов обладал очень хорошей аэродинамикой — Cx равнялся 0, 29." +
                " В 1950 году компания вернулась в Штутгарт.", "Понятно");
        }
    }
}