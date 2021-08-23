using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using DPProjectHerexamen.Models;
using DPProjectHerexamen.Repositories;
using Xamarin.Forms;

namespace DPProjectHerexamen.Views
{
    public partial class Favorites : ContentPage
    {
        ObservableCollection<Elephant> favorite;

        public Favorites(ObservableCollection<Elephant> favorites)
        {
            favorite = favorites;
            InitializeComponent();
            ShowElephants();
        }

        private async Task ShowElephants()
        {
            lvwElephants.ItemsSource = null;
            lvwElephants.ItemsSource = favorite;
        }

        private async void animalbutton_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var elephant = btn.Text;
            List<Elephant> elephants = await ElephantRepo.GetAnimalsAsync();

            foreach (var elephant_item in elephants)
            {
                if (elephant_item.Name == elephant)
                {
                    Navigation.PushAsync(new ElephantDetail(elephant_item));
                }
            }

        }

        private void btnNavBack_Clicked(object sender, EventArgs e)
        {
            GoBack();
        }

        private void GoBack()
        {
            Navigation.PopAsync();
        }

        async void RefreshView_Refreshing(System.Object sender, System.EventArgs e)
        {
            lvwElephants.ItemsSource = favorite;
            await Task.Delay(1000);
            myRefreshView.IsRefreshing = false;
        }
    }
}
