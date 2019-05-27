using System;
using Newtonsoft.Json;

namespace RequestApiLibrary.Model
{

    public class State
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
    
    public class Regiao
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("sigla")]
        public string sigla { get; set; }

        [JsonProperty("nome")]
        public string nome { get; set; }
    }
}
