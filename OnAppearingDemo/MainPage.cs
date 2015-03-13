using System;
using Xamarin.Forms;

namespace OnAppearingDemo
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var btn = new Button { Text = "Go modal" };
            btn.Clicked += (object sender, EventArgs e) => 
                {                   
                    var modal = new ModalPage();
                    Navigation.PushModalAsync(modal);
                };
            Content = new StackLayout()
                {

                    Children =
                        {
                            new Label { Text = "Main" },
                            btn
                        }
                    };            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DisplayAlert("OnAppearing!", "OnAppearing!", "Ok");
        }
    }
}

