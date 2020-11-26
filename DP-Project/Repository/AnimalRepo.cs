using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DPProject.Models;
using Newtonsoft.Json;


namespace DPProject.Repository
{
    public static class AnimalRepo
    {
        public static List<AnimalSpecy> favorites = new List<AnimalSpecy>();

        private static HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public static async Task<Animal> GetAnimalsAsync()
        {
            string url = "http://www.bloowatch.org/developers/json/species";
            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);

                    Animal animals = JsonConvert.DeserializeObject<Animal>(json);
                    return animals;
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static void addToFavorite(AnimalSpecy favorite)
        {
            favorites.Add(favorite);
        }
    }
}
