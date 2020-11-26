using System;
using System.Collections.Generic;
using DPProject.Models;
using DPProject.Repository;
using Xamarin.Forms;

namespace DPProject.Views
{
    public partial class AnimalDetail : ContentPage
    {
        public AnimalSpecy animal { get; set; }
        public AnimalDetail(AnimalSpecy animal)
        {
            InitializeComponent();
            this.animal = animal;
            AnimalName.Text = animal.Name;
            AnimalStatus.Text = animal.Status;
            AnimalLocation.Text = animal.Location;
            AnimalHabitat.Text = animal.Habitat;
            AnimalPopulation.Text = animal.Population;
            LoadImage(animal);
        }

        private void LoadImage(AnimalSpecy animal)
        {
            AnimalImage.Source = animal.Image.ImageSrc;
        }

        private void btnNavBack_Clicked(object sender, EventArgs e)
        {
            GoBack();
        }

        private void GoBack()
        {
            Navigation.PopAsync();
        }

        void btnMoreInfo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AnimalExtraDetail(animal));     
        }

        void btnLike_Clicked(System.Object sender, System.EventArgs e)
        {
            btnLike.Text = "Added to Favourites";
            AnimalRepo.addToFavorite(animal);
        }
    }
}
