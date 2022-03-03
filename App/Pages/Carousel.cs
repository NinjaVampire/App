using App.ContentPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App.Pages
{
    public class Carousel : CarouselPage
    {
        public Carousel()
        {
            Children.Add(new ContentPage1());
            Children.Add(new ContentPage2());
        }
    }
}