using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinApp
{
	public class Page1 : ContentPage
	{
		public Page1 ()
		{
            Label labelLarge = new Label { Text = "Username", FontSize = 40, HorizontalOptions = LayoutOptions.Center, TextColor = Color.White };

            Label labelSmall = new Label { Text = "This control is great for\n" + "displaying one or more\n" + "lines of text.", FontSize = 20, HorizontalOptions = LayoutOptions.CenterAndExpand, TextColor = Color.White };
            this.BackgroundColor = Color.Black;
            Button button = new Button { Text = "Make It So", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)), HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Fill };
            button.Clicked += (sender, args) => { button.Text = "It is so!"; };
            Entry entry = new Entry { Placeholder = "Username", TextColor=Color.White,VerticalOptions = LayoutOptions.Center, Keyboard = Keyboard.Text };
           // BoxView boxView = new BoxView { Color = Color.Silver, WidthRequest = 150, HeightRequest = 150, HorizontalOptions = LayoutOptions.StartAndExpand, VerticalOptions = LayoutOptions.Fill };
          //  Image image = new Image { Source = "icon.png", Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.End, VerticalOptions = LayoutOptions.Fill };
           // ScrollView scrollView = new ScrollView { VerticalOptions = LayoutOptions.FillAndExpand};

            Content = new StackLayout {
                Children = {
                    //new Label { Text = "Welcome to Xamarin.Forms!" }
                    labelLarge,
                    labelSmall,
                    button,
                    entry,
                   // boxView,
                   // image,
                   // scrollView

				}
			};
            this.Padding = new Thickness(20,20,20,20);// orspecing
		}
	}
}