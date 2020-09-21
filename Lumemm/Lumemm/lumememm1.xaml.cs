using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumemm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class lumememm1 : ContentPage
    {
        public lumememm1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private async void Random_Button_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Подтвердить действие", "Вы уверенны что хотите нажать?", "Да", "Нет");
            await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            hat1.BackgroundColor = Color.FromRgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            hat2.BackgroundColor = Color.FromRgb(r, g, b);
             r = rnd.Next(0, 255);
             g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
           ball1.BackgroundColor = Color.FromRgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            ball2.BackgroundColor = Color.FromRgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            ball3.BackgroundColor = Color.FromRgb(r, g, b);
        }

        private async void Hide_Button_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Подтвердить действие", "Вы уверенны что хотите нажать?", "Да", "Нет");
            await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");
            hat1.Opacity = 0;
            hat2.Opacity = 0;
            ball1.Opacity = 0;
            ball2.Opacity = 0;
            ball3.Opacity = 0;
        }

        private async void Melt_Button_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Подтвердить действие", "Вы уверенны что хотите нажать?", "Да", "Нет");
            await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");
            hat1.Opacity = 0.75;
            hat2.Opacity = 0.75;
            ball1.Opacity = 0.75;
            ball2.Opacity = 0.75;
            ball3.Opacity = 0.75;
            await Task.Run(() => Thread.Sleep(1000));
            hat1.Opacity = 0.50;
            hat2.Opacity = 0.50;
            ball1.Opacity = 0.50;
            ball2.Opacity = 0.50;
            ball3.Opacity = 0.75;
            await Task.Run(() => Thread.Sleep(1000));
            hat1.Opacity = 0.25;
            hat2.Opacity = 0.25;
            ball1.Opacity = 0.25;
            ball2.Opacity = 0.25;
            ball3.Opacity = 0.25;
            await Task.Run(() => Thread.Sleep(1000));
            hat1.Opacity = 0;
            hat2.Opacity = 0;
            ball1.Opacity = 0;
            ball2.Opacity = 0;
            ball3.Opacity = 0;
            await Task.Run(() => Thread.Sleep(1000));

        }

        private async void TurnOver_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Подтвердить действие", "Вы уверенны что хотите нажать?", "Да", "Нет");
            await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");
            hat1.Rotation = 40;
            hat2.Rotation = 20;
        }
    }
}