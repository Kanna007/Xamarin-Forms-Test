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
                    //If only one devices connected this line no needed
                    //.DeviceSerial("EMULATOR30X1X5X0")
                    .InstalledApp("com.companyname.demoapp")
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}