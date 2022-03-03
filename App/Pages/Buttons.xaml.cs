using App.ContentPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Buttons : ContentPage
    {
        public Buttons()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentPage1());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentPage2());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Nav());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Carousel());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyTabPage());
        }
    }
}