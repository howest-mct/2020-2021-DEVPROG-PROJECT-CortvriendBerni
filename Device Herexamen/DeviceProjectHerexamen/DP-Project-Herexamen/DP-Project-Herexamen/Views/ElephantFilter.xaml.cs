using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DPProjectHerexamen.Views
{
    public partial class ElephantFilter : ContentPage
    {
        public ElephantFilter()
        {
            InitializeComponent();
        }

        private void Male_Elephants(object sender, EventArgs e)
        {
            NavigateToMaleElephantList();
        }

        private void NavigateToMaleElephantList()
        {
            Navigation.PushAsync(new MaleElephants());
        }

        private void Female_Elephants(object sender, EventArgs e)
        {
            NavigateToFemaleElephantList();
        }

        private void NavigateToFemaleElephantList()
        {
            Navigation.PushAsync(new FemaleElephants());
        }

        private void Asian_Elephants(object sender, EventArgs e)
        {
            NavigateToAsianElephantList();
        }

        private void NavigateToAsianElephantList()
        {
            Navigation.PushAsync(new AsianElephants());
        }

        private void African_Elephants(object sender, EventArgs e)
        {
            NavigateToAfricanElephantList();
        }

        private void NavigateToAfricanElephantList()
        {
            Navigation.PushAsync(new AfricanElephants());
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
