using System;
using Newtonsoft.Json;

namespace RequestApiLibrary.Model
{
    public class Country
    {

        [JsonProperty("CodigoArea")]
        public string Id { get; set; }

        [JsonProperty("Pais")]
        public string Name { get; set; }

        [JsonProperty("Sigla")]
        public string Initials { get; set; }
    }
}
