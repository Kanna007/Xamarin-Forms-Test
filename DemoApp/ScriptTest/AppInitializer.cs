using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace ScriptTest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android
                    .EnableLocalScreenshots()
                    .InstalledApp("com.companyname.demoapp")
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}