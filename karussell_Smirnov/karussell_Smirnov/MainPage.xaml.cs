using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace karussell_Smirnov
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            var redContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Red",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        },
                        new BoxView
                        {Color = Color.Red,
                        WidthRequest = 200,
                        HeightRequest = 200,
                        HorizontalOptions = LayoutOptions.End,
                        VerticalOptions = LayoutOptions.EndAndExpand
                        }
                    }
                }
            };
            var YellowContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Yell",
                            FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
                        },
                        new BoxView
                        {Color = Color.Yellow,
                        WidthRequest = 200,
                        HeightRequest = 200,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
            var BrownContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Brow",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                        },
                        new BoxView
                        {Color = Color.Brown,
                        WidthRequest = 200,
                        HeightRequest = 200,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
            Children.Add(redContentPage);
            Children.Add(YellowContentPage);
            Children.Add(BrownContentPage);
        }
    }
}
