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
        public AdMobRenderer(Context context) : base(context) {}

        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            if ((Element is AdMobView adMobElement) && (e.OldElement == null))
            {
                var ad = new AdView(Context)
                {
                    AdSize = AdSize.Banner,
                    AdUnitId = ""
                };

                var requestbuilder = new AdRequest.Builder();
                ad.LoadAd(requestbuilder.Build());
                SetNativeControl(ad);
            }
        }
    }
}