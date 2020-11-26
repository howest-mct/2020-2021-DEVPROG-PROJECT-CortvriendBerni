using System;
using Xamarin.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Net.Http;

namespace DPProject.Models
{
    public class Animal
    {
        [JsonProperty("allSpecies")]
        public List<AnimalSpecy> AnimalSpecies { get; set; }
    }

    public class AnimalSpecy
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "scientific_name")]
        public string ScientificName { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "population")]
        public string Population { get; set; }

        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        [JsonProperty(PropertyName = "habitat")]
        public string Habitat { get; set; }

        [JsonProperty(PropertyName = "image")]
        public Image Image { get; set; }

        public bool isFavorite { get; set; }
    }

    public class Image
    {
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
            

        public ImageSource ImageSrc
        {
            get
            {
                return ImageSource.FromStream(() => new HttpClient().GetStreamAsync("http://www.bloowatch.org"+Url).Result);
            }
        }
    }
}
