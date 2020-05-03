using Xamarin.Forms.Platform.Android;
using Android.Gms.Ads;
using Xamarin.Forms;
using AdmobTest.Controls;
using AdmobTest.Droid.Renders;
using Android.Content;

[assembly: ExportRenderer(typeof(AdMobView), typeof(AdMobRenderer))]
namespace AdmobTest.Droid.Renders
{
    public class AdMobRenderer : ViewRenderer
    {
        public AdMobRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            if ((Element is AdMobView adMobElement) && (e.OldElement == null))
            {
                var adId = "ca-app-pub-3940256099942544/6300978111";

                var ad = new AdView(Context)
                {
                    AdSize = AdSize.Banner,
                    AdUnitId = adId
                };

                var requestbuilder = new AdRequest.Builder();
                ad.LoadAd(requestbuilder.Build());
                SetNativeControl(ad);
            }
        }
    }
}