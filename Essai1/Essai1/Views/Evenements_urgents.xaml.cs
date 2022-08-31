using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Essai1.Views
{
    public partial class Evenements_urgents : ContentPage
    {
        private bool isSearchVisible;

        public bool IsSearchVisible
        {
            get => isSearchVisible;
            set
            {
                isSearchVisible = value;
                OnPropertyChanged();
            }
        }

        public Evenements_urgents()
        {
            isSearchVisible = true;
            BindingContext = this;
            InitializeComponent();
            ToolbarItem item = new ToolbarItem()
            {
                IconImageSource = ImageSource.FromFile("search_icon.png"),
                Order = ToolbarItemOrder.Primary,
                Priority = 0,
            };
        }

        private async void PrimaryClicked(object sender, System.EventArgs e)
        {
            var toolbarItem = sender as ToolbarItem;
            switch (toolbarItem.ClassId)
            {
                case "search":
                    IsSearchVisible = !IsSearchVisible;
                    break;
                case "share":
                    var response = await DisplayActionSheet("Partager via", "", "OK", new string[] { "Bluetooth", "Whatsapp" });
                    Share(response);
                    break;
            }
        }

        private void Share(string response)
        {
            switch (response)
            {
                case "Bluetooth":
                    Console.WriteLine("Partage via Bluetooth");
                    break;
                case "Whatsapp":
                    Console.WriteLine("Partage via Whatsapp");
                    break;
            }
        }

        private void SecondaryClicked(object sender, System.EventArgs e)
        {
            var toolbarItem = sender as ToolbarItem;
            switch (toolbarItem.ClassId)
            {
                case "modifier":
                    break;
                case "trier":
                    break;
                case "deplacer":
                    break;
            }
        }
    }
} 