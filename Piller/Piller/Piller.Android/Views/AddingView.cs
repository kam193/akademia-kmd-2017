using Android.App;
using Android.Content;
using Android.OS;
using Android.Util;
using Android.Views;

namespace Piller.Android.Views
{
    [Activity(Label = "View for AddingView")]
    public class AddingView : BaseView
    {
        protected override int LayoutResource => Resource.Layout.AddingView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
        }
    }
}