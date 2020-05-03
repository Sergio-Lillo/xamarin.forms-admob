using AdmobTest.Controls;
using Xamarin.Forms;

namespace AdmobTest.Views.C_sharp
{
    public class AnuncioPagina : ContentPage
    {
        public AdMobView anuncio = new AdMobView
        {
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.FillAndExpand
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