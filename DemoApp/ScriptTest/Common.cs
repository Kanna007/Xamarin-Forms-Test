using System;
using System.IO;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace ScriptTest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Common 
    {
        IApp app;
        Platform platform;

        public Common(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }
        
        
    }
}
