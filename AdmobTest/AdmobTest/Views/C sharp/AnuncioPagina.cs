using AdmobTest.Controls;
using Xamarin.Forms;

namespace AdmobTest.Views.C_sharp
{
    public class AnuncioPagina : ContentPage
    {
        public AdMobView anuncio = new AdMobView
        {
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.Start
        };

        public AnuncioPagina()
        {
            BackgroundColor = Color.Black;

            Content = new StackLayout
            {
                Children =
                {
                    anuncio
                }
            };
        }
    }
}