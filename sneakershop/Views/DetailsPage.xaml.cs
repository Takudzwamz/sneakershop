using System;
using System.Collections.Generic;
using sneakershop.ViewModels;
using Xamarin.Forms;

namespace sneakershop.Views
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage()
        {
            InitializeComponent();
            BindingContext = new SneakersViewModel();
        }
    }
}
