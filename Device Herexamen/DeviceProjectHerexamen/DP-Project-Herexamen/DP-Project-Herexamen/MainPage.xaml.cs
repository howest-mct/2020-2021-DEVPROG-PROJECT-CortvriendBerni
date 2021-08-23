using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPProjectHerexamen.Models;
using DPProjectHerexamen.Repositories;
using DPProjectHerexamen.Views;
using Xamarin.Forms;

namespace DP_Project_Herexamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void List_Elephants(object sender, EventArgs e)
        {
            NavigateToElephantList();
        }

        private void NavigateToElephantList()
        {
            Navigation.PushAsync(new ElephantList());
        }

        private void List_Filter(object sender, EventArgs e)
        {
            NavigateToFilterList();
        }

        private void NavigateToFilterList()
        {
            Navigation.PushAsync(new ElephantFilter());
        }

        private void List_Favorites(object sender, EventArgs e)
        {
            NavigateToFavoriteList();

        }

        private void NavigateToFavoriteList()
        {
            ObservableCollection<Elephant> favorites = ElephantRepo.favorites;

            Navigation.PushAsync(new Favorites(favorites));
        }
    }
}
