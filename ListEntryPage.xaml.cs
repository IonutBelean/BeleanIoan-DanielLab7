using Microsoft.Maui.Controls; // Use the MAUI namespace
using BeleanIoan_DanielLab7.Models;
using System;
using System.Threading.Tasks;

namespace BeleanIoan_DanielLab7
{
    public partial class ListEntryPage : ContentPage
    {
        public ListEntryPage()
        {
            InitializeComponent(); // Initializes components declared in XAML
        }

        // Load the shopping lists when the page appears
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            // Fetch the list of shopping lists from the database and set it as the ItemsSource for the ListView
            listView.ItemsSource = await App.Database.GetShopListsAsync();
        }

        // Navigate to the ListPage to add a new shopping list
        async void OnShopListAddedClicked(object sender, EventArgs e)
        {
            // Create a new ShopList instance and set it as the BindingContext for ListPage
            await Navigation.PushAsync(new ListPage
            {
                BindingContext = new ShopList()
            });
        }

        // Navigate to the ListPage with the selected shopping list
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                // Bind the selected shopping list to the ListPage for viewing or editing
                await Navigation.PushAsync(new ListPage
                {
                    BindingContext = e.SelectedItem as ShopList
                });

                // Deselect the item after navigating
                ((ListView)sender).SelectedItem = null;
            }
        }
    }
}
