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
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BackgroundColor = Color.Wheat;
            Button Audi_btn = new Button { Text = "Audi", BackgroundColor = Color.Green, Margin = 10, Padding = 10 };
            StackLayout st = new StackLayout();
            st.Children.Add(Audi_btn);
            Content = st;
            Audi_btn.Clicked += Audi_btn_Clicked;

            Button BMW_btn = new Button { Text = "BMW", BackgroundColor = Color.Green, Margin = 10 };
            st.Children.Add(BMW_btn);
            Content = st;
            BMW_btn.Clicked += BMW_btn_Clicked;

            Button Ferrari_btn = new Button { Text = "Ferrari", BackgroundColor = Color.Green, Margin = 10 };
            st.Children.Add(Ferrari_btn);
            Content = st;
            Ferrari_btn.Clicked += Ferrari_btn_Clicked;

            Button Jeep_btn = new Button { Text = "Jeep", BackgroundColor = Color.Green, Margin = 10 };
            st.Children.Add(Jeep_btn);
            Content = st;
            Jeep_btn.Clicked += Jeep_btn_Clicked;

            Button Lamborghini_btn = new Button { Text = "Lamborghini", BackgroundColor = Color.Green, Margin = 10 };
            st.Children.Add(Lamborghini_btn);
            Content = st;
            Lamborghini_btn.Clicked += Lamborghini_btn_Clicked;

            Button Mercedes_btn = new Button { Text = "Mercedes-Benz", BackgroundColor = Color.Green, Margin = 10 };
            st.Children.Add(Mercedes_btn);
            Content = st;
            Mercedes_btn.Clicked += Mercedes_btn_Clicked;

            Button Nissan_btn = new Button { Text = "Nissan", BackgroundColor = Color.Green, Margin = 10 };
            st.Children.Add(Nissan_btn);
            Content = st;
            Nissan_btn.Clicked += Nissan_btn_Clicked;

            Button Rolls_btn = new Button { Text = "Rolls Royce", BackgroundColor = Color.Green, Margin = 10 };
            st.Children.Add(Rolls_btn);
            Content = st;
            Rolls_btn.Clicked += Rolls_btn_Clicked;
        }

        private async void Nissan_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Nissan());
        }

        private async void Jeep_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Jeep());
        }

        private async void Rolls_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Rolls());
        }

        private async void Mercedes_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Mercedes());
        }

        private async void BMW_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BMW());
        }

        private async void Ferrari_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ferrari());
        }

        private async void Lamborghini_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lamborghini());
        }

        private async void Audi_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Audi());
        }
    }
}