using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPProject.Models;
using DPProject.Repository;
using DPProject.Views;
using Xamarin.Forms;

namespace DP_Project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void List_Animals(object sender, EventArgs e)
        {
            NavigateToAnimalList();

        }

        private void NavigateToAnimalList()
        {
            Navigation.PushAsync(new AnimalList());
        }

        private void List_Favorites(object sender, EventArgs e)
        {
            NavigateToFavoriteList();

        }

        private void NavigateToFavoriteList()
        {
            List<AnimalSpecy> favorites = AnimalRepo.favorites;

            Navigation.PushAsync(new Favorites(favorites));
        }
    }
}
