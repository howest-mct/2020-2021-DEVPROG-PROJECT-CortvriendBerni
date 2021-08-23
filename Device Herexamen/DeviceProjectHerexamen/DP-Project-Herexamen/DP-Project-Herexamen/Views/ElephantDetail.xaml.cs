using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DPProjectHerexamen.Models;
using DPProjectHerexamen.Repositories;
using Xamarin.Forms;

namespace DPProjectHerexamen.Views
{
    public partial class ElephantDetail : ContentPage
    {
        public Elephant elephant { get; set; }
        public ElephantDetail(Elephant elephant)
        {
            InitializeComponent();
            this.elephant = elephant;
            ElephantName.Text = elephant.Name;
            ElephantAffiliation.Text = elephant.Affiliation;
            ElephantSpecies.Text = elephant.Species;
            ElephantSex.Text = elephant.Sex;
            ElephantFictional.Text = elephant.Fictional;
            LoadImage(elephant);
            checkLiked();
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

        void btnMoreInfo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ElephantExtraDetail(elephant));
        }

        void btnLike_Clicked(System.Object sender, System.EventArgs e)
        {
            if(btnLike.Text == "Add to favourites")
            {
                btnLike.Text = "Remove from favourites";
                btnLike.BackgroundColor = Color.FromHex("A40E4C");
                btnLike.TextColor = Color.White;
                ElephantRepo.addToFavorite(elephant);
            }

            else if (btnLike.Text == "Remove from favourites")
            {
                btnLike.Text = "Add to favourites";
                btnLike.BackgroundColor = Color.FromHex("65A281");
                ElephantRepo.RemoveFromFavorite(elephant);
            }
        }

        private async void checkLiked()
        {
            List<Elephant> elephants = await ElephantRepo.GetAnimalsAsync();
            foreach (var elephant_item in ElephantRepo.favorites)
            {
                if (elephant_item.Name == elephant.Name)
                {
                    btnLike.Text = "Remove from favourites";
                    btnLike.BackgroundColor = Color.FromHex("A40E4C");
                }
            }
        }
    }
}
