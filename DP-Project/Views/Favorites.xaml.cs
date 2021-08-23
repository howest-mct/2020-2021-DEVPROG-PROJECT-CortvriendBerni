using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DPProject.Models;
using DPProject.Repository;
using Xamarin.Forms;

namespace DPProject.Views
{
    public partial class Favorites : ContentPage
    {
        List<AnimalSpecy> favorite;
        public Favorites(List<AnimalSpecy> favorites)
        {
            favorite = favorites;
            InitializeComponent();
            ShowAnimals();
        }

        private async Task ShowAnimals()
        {
            lvwAnimals.ItemsSource = favorite;
        }

    private async void animalbutton_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var animal = btn.Text;
            Animal animals = await AnimalRepo.GetAnimalsAsync();

            foreach (var animal_item in animals.AnimalSpecies)
            {
                if (animal_item.Name == animal)
                {
                    Navigation.PushAsync(new AnimalDetail(animal_item));
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
    }
}
