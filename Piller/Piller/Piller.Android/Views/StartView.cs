using Android.App;
using Android.Content;
using Android.OS;
using Android.Util;
using Android.Views;

namespace Piller.Android.Views
{
    [Activity(Label = "View for StartView")]
    public class StartView : BaseView
    {
        protected override int LayoutResource => Resource.Layout.StartView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
        }
    }
}