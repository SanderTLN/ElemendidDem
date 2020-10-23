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
    public partial class Ferrari : ContentPage
    {
        Button btn1, btn2;
        public Ferrari()
        {
            BackgroundColor = Color.Wheat;
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "Ferrari", FontSize = 30, TextColor = Color.Black },
                new Rectangle(170, 20, 100, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Ferrari NV — итальянская компания, выпускающая спортивные и гоночные автомобили, базирующаяся в Маранелло.", FontSize = 20, TextColor = Color.Black },
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
            DisplayAlert("Больше", "Основана в 1947 году Энцо Феррари как Scuderia Ferrari, компания спонсировала гонщиков и производила гоночные машины до 1947 года." +
                " С 1947 года начала выпуск спортивных автомобилей, разрешённых к использованию на дорогах общего пользования, под маркой «Ferrari S.p.A.»." +
                " На протяжении всей своей истории, компания участвует в различных гонках, особенно в Формуле-1, где она имеет наибольший успех." +
                " Эмблема «Феррари» — гарцующая лошадь на жёлтом фоне." +
                " Традиционный цвет автомобилей — красный, но компания выпускает автомобили и других цветов.", "Понятно");
        }
        private void Btn2_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("История", "", "Понятно");
        }
    }
}