using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumemm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        BoxView head, eye1, eye2, lips, ball1, ball2, ball3;
        public Page2()
        {
            AbsoluteLayout abs = new AbsoluteLayout();
            head = new BoxView { Color = Color.LightBlue, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(head, new Rectangle(0.5, 0.25, 80, 80));
            AbsoluteLayout.SetLayoutFlags(head, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(head);

            eye1 = new BoxView { Color = Color.Black, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(eye1, new Rectangle(0.3, 0.3, 30, 30));
            AbsoluteLayout.SetLayoutFlags(eye1, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(eye1);

            eye2 = new BoxView { Color = Color.Black, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(eye2, new Rectangle(0.8, 0.3, 30, 30));
            AbsoluteLayout.SetLayoutFlags(eye2, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(eye2);

            ball1 = new BoxView { Color = Color.White, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(ball1, new Rectangle(0.5, 0.5, 100, 100));
            AbsoluteLayout.SetLayoutFlags(ball1, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(ball1);

            ball2 = new BoxView { Color = Color.White, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(ball2, new Rectangle(0.5, 0.5, 100, 100));
            AbsoluteLayout.SetLayoutFlags(ball2, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(ball2);

            ball3 = new BoxView { Color = Color.White, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(ball3, new Rectangle(0.5, 0.5, 100, 100));
            AbsoluteLayout.SetLayoutFlags(ball3, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(ball3);



            Content = abs;
        }
    }
}