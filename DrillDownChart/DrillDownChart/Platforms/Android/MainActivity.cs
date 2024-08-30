﻿using Android.App;
using Android.Content.PM;
using Android.OS;

namespace DrillDownChart
{
    [Activity(Theme = "@style/Maui.SplashTheme", ScreenOrientation = ScreenOrientation.Landscape , MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
    }
}
