using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using DPProjectHerexamen.Models;
using Newtonsoft.Json;

namespace DPProjectHerexamen.Repositories
{
    public static class ElephantRepo
    {
        public static ObservableCollection<Elephant> favorites = new ObservableCollection<Elephant>();

        private static HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public static async Task<List<Elephant>> GetAnimalsAsync()
        {
            string url = "https://elephant-api.herokuapp.com/elephants";
            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);

                    List<Elephant> elephants = JsonConvert.DeserializeObject<List<Elephant>>(json);
                    return elephants;
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static async Task<List<Elephant>> GetMaleElephants()
        {
            string url = "https://elephant-api.herokuapp.com/elephants/sex/male";
            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);

                    List<Elephant> elephants = JsonConvert.DeserializeObject<List<Elephant>>(json);
                    return elephants;
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static async Task<List<Elephant>> GetFeMaleElephants()
        {
            string url = "https://elephant-api.herokuapp.com/elephants/sex/female";
            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);

                    List<Elephant> elephants = JsonConvert.DeserializeObject<List<Elephant>>(json);
                    return elephants;
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static async Task<List<Elephant>> GetAsianElephants()
        {
            string url = "https://elephant-api.herokuapp.com/elephants/species/asian";
            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);

                    List<Elephant> elephants = JsonConvert.DeserializeObject<List<Elephant>>(json);
                    return elephants;
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static async Task<List<Elephant>> GetAfricanElephants()
        {
            string url = "https://elephant-api.herokuapp.com/elephants/species/african";
            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);

                    List<Elephant> elephants = JsonConvert.DeserializeObject<List<Elephant>>(json);
                    return elephants;
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public static async Task addToFavorite(Elephant favorite)
        {
            favorites.Add(favorite);
        }

        public static async Task RemoveFromFavorite(Elephant favorite)
        {
            favorites.Remove(favorite);
        }
    }
}
