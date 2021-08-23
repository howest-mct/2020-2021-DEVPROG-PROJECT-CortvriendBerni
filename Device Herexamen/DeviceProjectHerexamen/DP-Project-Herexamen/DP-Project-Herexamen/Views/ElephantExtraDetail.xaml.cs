using System;
using System.Collections.Generic;
using DPProjectHerexamen.Models;
using Xamarin.Forms;

namespace DPProjectHerexamen.Views
{
    public partial class ElephantExtraDetail : ContentPage
    {
        public Elephant elephant { get; set; }
        public ElephantExtraDetail(Elephant elephant)
        {
            InitializeComponent();
            this.elephant = elephant;
            ElephantName.Text = elephant.Name;
            ElephantDOB.Text = elephant.DateOfBirth;
            ElephantDOD.Text = elephant.DateOfDeath;
            ElephantDescription.Text = elephant.Description;
            LoadImage(elephant);
        }

        private void LoadImage(Elephant elephant)
        {
            ElephantImage.Source = elephant.Image;
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
