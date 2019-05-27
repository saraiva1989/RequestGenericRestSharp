using System;
using Newtonsoft.Json;

namespace RequestApiLibrary.Model
{
    public class City
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("nome")]
        public string nome { get; set; }

        [JsonProperty("microrregiao")]
        public Microrregiao microrregiao { get; set; }
    }
    
    public class UF
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("sigla")]
        public string sigla { get; set; }

        [JsonProperty("nome")]
        public string nome { get; set; }

        [JsonProperty("regiao")]
        public Regiao regiao { get; set; }
    }

    public class Mesorregiao
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("nome")]
        public string nome { get; set; }

        [JsonProperty("UF")]
        public UF UF { get; set; }
    }

    public class Microrregiao
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("nome")]
        public string nome { get; set; }

        [JsonProperty("mesorregiao")]
        public Mesorregiao mesorregiao { get; set; }
    }
}