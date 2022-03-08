using System;
using System.IO;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using static ScriptTest.Common;

namespace ScriptTest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]

    public class MapControl_TestCases
    {
        IApp app;
        Platform platform;
        
        public MapControl_TestCases(Platform platform) 
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void Maps_Types001()
        {
            app.Tap("map");
            app.Tap("sat");
            Thread.Sleep(2000);
            app.Screenshot("Maps_Types001");
        }
        [Test]
        public void Maps_Types002()
        {
            app.Tap("map");
            app.Tap("street");
            Thread.Sleep(2000);
            app.Screenshot("Maps_Types002");
        }
        [Test]
        public void Maps_Types003()
        {
            app.Tap("map");
            app.Tap("hybrid");
            Thread.Sleep(2000);
            app.Screenshot("Maps_Types003");
        }

    }
}
