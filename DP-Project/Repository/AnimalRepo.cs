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
        private static HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public static async Task<List<Animal>> GetAnimalsAsync()
        {
            string url = "http://www.bloowatch.org/developers/json/species";
            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);

                    List<Animal> animals = JsonConvert.DeserializeObject<List<Animal>>(json);
                    return animals;
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
