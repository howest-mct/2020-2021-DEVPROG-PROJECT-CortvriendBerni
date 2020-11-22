using System;
using System.Collections.Generic;
using DPProject.Models;
using Xamarin.Forms;

namespace DPProject.Views
{
    public partial class AnimalDetail : ContentPage
    {
        public AnimalDetail(AnimalSpecy animal)
        {
            InitializeComponent();
            AnimalName.Text = animal.Name;
        }
    }
}
