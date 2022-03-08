using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void click(object sender, EventArgs e)
        {
            returntype.Text = (Convert.ToString( Firstname.Text) + Convert.ToString(Lastname.Text)).ToString();
        }

        private async void Nextpage1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoApp.NextPage_1());
        }

        private async void Mapcontrolpage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DemoApp.Page1());
        }
    }
}
