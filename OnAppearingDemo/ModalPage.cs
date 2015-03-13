using System;
using Xamarin.Forms;

namespace OnAppearingDemo
{
    public class ModalPage : ContentPage
    {
        public ModalPage()
        {
            var btn = new Button { Text = "Close" };
            btn.Clicked += (object sender, EventArgs e) => 
                {
                    Navigation.PopModalAsync(); 
                };
            Content = new StackLayout()
            {
                    
                Children =
                {
                    new Label { Text = "Modal" },
                    btn
                }
            };
        }
    }
}

