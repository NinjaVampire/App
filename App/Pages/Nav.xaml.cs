using App.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.ContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Nav : ContentPage
    {
        public Nav()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentPage1());
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentPage2());
        }

        private void ToolbarItem_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyTabPage());
        }

        private void ToolbarItem_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Carousel());
        }
    }
}