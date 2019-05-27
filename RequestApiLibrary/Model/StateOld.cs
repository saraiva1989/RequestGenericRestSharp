using System;
using Newtonsoft.Json;

namespace RequestApiLibrary.Model
{
    public class StateOld
    {
        [JsonProperty("Capital")]
        public string Capital { get; set; }

        [JsonProperty("Estado")]
        public string Name { get; set; }

        [JsonProperty("UF")]
        public string UF { get; set; }
    }

}
