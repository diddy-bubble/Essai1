using Essai1.Models;
using Essai1.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Essai1.Views
{
    public partial class TachePage : ContentPage
    {
        TachePageViewModel viewModel;
        public TachePage()
        {
            viewModel = new TachePageViewModel();
            BindingContext = viewModel;
            InitializeComponent();
        }

    }
}