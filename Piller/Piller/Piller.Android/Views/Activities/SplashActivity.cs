using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Support.V7.AppCompat;

// Declarations for Android hardware and software features used by your application go here, for example
//[assembly: UsesFeature("android.hardware.camera", Required = false)]

// Declarations for Android permissions used by your application go here, for example
//[assembly: Permission(Name = Android.Manifest.Permission.Internet)]

namespace Piller.Android.Views
{
    [Activity(
        MainLauncher = true,
        Theme = "@style/SplashTheme",
        Icon = "@mipmap/icon",
        NoHistory = true,
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreenActivity : MvxSplashScreenAppCompatActivity
    {
    }
}