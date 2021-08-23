﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DPProjectHerexamen.Models;
using DPProjectHerexamen.Repositories;
using Xamarin.Forms;

namespace DPProjectHerexamen.Views
{
    public partial class AsianElephants : ContentPage
    {
        public AsianElephants()
        {
            InitializeComponent();
            ShowElephants();
        }

        private async void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            List<Elephant> elephants = await ElephantRepo.GetAsianElephants();
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                lvwElephant.ItemsSource = elephants;
            }

            else
            {
                //list.ItemsSource = tempdata.Where(x => x.Name.StartsWith(e.NewTextValue));
                lvwElephant.ItemsSource = elephants.Take(47).Where(x => x.Name.ToUpper().StartsWith(searchBar.Text.ToUpper()));
            }
        }

        private async Task ShowElephants()
        {
            List<Elephant> elephants = await ElephantRepo.GetAsianElephants();
            lvwElephant.ItemsSource = elephants;
        }

        private async void elephantButton_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var name = btn.Text;
            List<Elephant> elephants = await ElephantRepo.GetAsianElephants();

            foreach (var elephant_item in elephants)
            {
                if (elephant_item.Name == name)
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
    }
}
