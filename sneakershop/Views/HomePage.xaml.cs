using System;
using System.Collections.Generic;
using sneakershop.ViewModels;
using Xamarin.Forms;

namespace sneakershop.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new SneakersViewModel();
        }
    }
}
