using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace DemoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Satilite_Clicked(object sender, EventArgs e)
        {
            MapControl.MapType = MapType.Satellite;
        }

        private void Street_Clicked(object sender, EventArgs e)
        {
            MapControl.MapType = MapType.Street;
        }

        private void Hybrid_Clicked(object sender, EventArgs e)
        {
            MapControl.MapType = MapType.Hybrid;
        }
    }
}