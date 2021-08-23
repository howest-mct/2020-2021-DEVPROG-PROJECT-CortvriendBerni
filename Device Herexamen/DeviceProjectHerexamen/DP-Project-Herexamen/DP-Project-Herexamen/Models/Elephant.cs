using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace DPProjectHerexamen.Models
{
    //public class Elephant
    //{
    //    public List<ElephantSpecy> ElephantSpecies { get; set; }
    //}

    public class Elephant
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "affiliation")]
        public string Affiliation { get; set; }

        [JsonProperty(PropertyName = "species")]
        public string Species { get; set; }

        [JsonProperty(PropertyName = "sex")]
        public string Sex { get; set; }

        [JsonProperty(PropertyName = "fictional")]
        public string Fictional { get; set; }

        [JsonProperty(PropertyName = "dob")]
        public string DateOfBirth { get; set; }

        [JsonProperty(PropertyName = "dod")]
        public string DateOfDeath { get; set; }

        [JsonProperty(PropertyName = "note")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        public ImageSource ImageSrc
        {
            get
            {
                return ImageSource.FromStream(() => new HttpClient().GetStreamAsync(Image).Result);
            }
        }

        public bool isFavorite { get; set; }
    }

    //public class Image
    //{

    //    public ImageSource ImageSrc
    //    {
    //        get
    //        {
    //            return ImageSource.FromStream(() => new HttpClient().GetStreamAsync(Elephant).Result);
    //        }
    //    }
    //}
}
