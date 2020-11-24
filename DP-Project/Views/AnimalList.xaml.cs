﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DPProject.Models;
using DPProject.Repository;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DPProject.Views
{
    public partial class AnimalList : ContentPage
    {
        public AnimalList()
        {
            InitializeComponent();
            ShowAnimals();
        }

        private async Task ShowAnimals()
        {
            Animal animals = await AnimalRepo.GetAnimalsAsync();
            lvwAnimals.ItemsSource = animals.AnimalSpecies;

        }

        private async void animalbutton_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var animal = btn.Text;
            Animal animals = await AnimalRepo.GetAnimalsAsync();

            //for (int i = 0; i < 13; i++) { 
            //    if (animals.AnimalSpecies[i].Name == animal)
            //    {
            //        Navigation.PushAsync(new AnimalDetail(animals.AnimalSpecies[i]));
            //    }
            //}

            foreach (var animal_item in animals.AnimalSpecies)
            {
                if(animal_item.Name == animal)
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


        //public Animal animal { get; set; }

        //private void FreshDigimon_Clicked(object sender, EventArgs e)
        //{
        //    NavigateToFreshImage();
        //}
    }
}
