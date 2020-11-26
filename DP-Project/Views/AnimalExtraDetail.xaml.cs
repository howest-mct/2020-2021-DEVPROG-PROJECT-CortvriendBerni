using System;
using System.Collections.Generic;
using DPProject.Models;
using DPProject.Repository;
using Xamarin.Forms;

namespace DPProject.Views
{
    public partial class AnimalExtraDetail : ContentPage
    {
        public AnimalSpecy animal { get; set; }
        public AnimalExtraDetail(AnimalSpecy animal)
        {
            InitializeComponent();
            this.animal = animal;
            AnimalName.Text = animal.Name;
            AnimalDescription.Text = animal.Description;
            AnimalScientificName.Text = animal.ScientificName;
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
    }
}
