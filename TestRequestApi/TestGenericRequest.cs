using System;
using System.Collections.Generic;
using RequestApiLibrary.Service;
using Xunit;
using RestSharp;
using RequestApiLibrary.Model;
using Newtonsoft.Json;
using Microsoft.Extensions.DependencyInjection;

namespace TestRequestApi
{
    public class TestGenericRequest
    {
        private readonly GenericRequest _genericRequest = new GenericRequest();

        [Fact]
        public void TestGet()
        {
            var param = new Dictionary<string, string>();
            param.Add("location", "-23.563844,-46.634836");
            param.Add("radius", "2000");
            param.Add("types", "restaurant");
            param.Add("key", "AIzaSyD7UFeXIEm7PA9JFVuukjbctsUK_xKShX8");

            var request = _genericRequest.ReturnJson(null, param, RestSharp.Method.GET, "https://maps.googleapis.com/maps/api/place/nearbysearch/json");
            Object.Equals(!string.IsNullOrEmpty(request), request);
        }

        [Fact]
        public void TestPost()
        {
            var param = new Dictionary<string, string>();
            var headers = new Dictionary<string, string>();
            param.Add("codigoTabelaReferencia", "231");
            param.Add("codigoTipoVeiculo", "1");

            headers.Add("Host", "veiculos.fipe.org.br");
            headers.Add("Referer", "http://veiculos.fipe.org.br");
            //headers.Add("Content-Type", "application/json");

            var request = _genericRequest.ReturnJson(headers, param, RestSharp.Method.POST, "http://veiculos.fipe.org.br/api/veiculos/ConsultarMarcas");

            Object.Equals(!string.IsNullOrEmpty(request), request);
        }

        [Fact]
        public void TestCountry()
        {
            var request = _genericRequest.ReturnJson(null, null, Method.GET, "http://api.londrinaweb.com.br/PUC/Paisesv2/0/1000");
            var country = JsonConvert.DeserializeObject<List<Country>>(request);
            Assert.True(country.Count > 0);
        }

        [Theory]
        [InlineData("br")]
        [InlineData("us")]
        public void TestState(string country)
        {
            var request = _genericRequest.ReturnJson(null, null, Method.GET, $"http://api.londrinaweb.com.br/PUC/Estados/{country}/0/10000");
            var state = JsonConvert.DeserializeObject<List<StateOld>>(request);
            Assert.True(state.Count > 0);
        }

        [Fact]
        public void TestIBGEState()
        {
            var request = _genericRequest.ReturnJson(null, null, Method.GET, "http://servicodados.ibge.gov.br/api/v1/localidades/estados/");
            var state = JsonConvert.DeserializeObject<List<State>>(request);
            Assert.True(state.Count > 0);
        }

        [Theory]
        [InlineData(12)]
        [InlineData(35)]
        public void TestIBGECity(int cityId)
        {
            var request = _genericRequest.ReturnJson(null, null, Method.GET, $"http://servicodados.ibge.gov.br/api/v1/localidades/estados/{cityId}/municipios");
            var state = JsonConvert.DeserializeObject<List<City>>(request);
            Assert.True(state.Count > 0);
        }

        [Theory]
        [InlineData("sp", "br")]
        [InlineData("rj", "br")]
        [InlineData("ny", "us")]
        public void TestCity(string state, string country)
        {
            var request = _genericRequest.ReturnJson(null, null, Method.GET, $"http://api.londrinaweb.com.br/PUC/Cidades/{state}/{country}/0/10000");
            var city = JsonConvert.DeserializeObject<List<string>>(request);
            Assert.True(city.Count > 0);
        }

        [Fact]
        public void TestStackOverflowTechnologyForPopularity()
        {
            var param = new Dictionary<string, string>();
            param.Add("page", "1");
            param.Add("order", "desc");
            param.Add("sort", "popular");
            param.Add("site", "stackoverflow");

            var request = _genericRequest.ReturnJson(null, param, Method.GET, "https://api.stackexchange.com/2.2/tags");
            var technology = JsonConvert.DeserializeObject<Technology>(request);
            Assert.True(technology.items.Count > 0);
        }

        [Theory]
        [InlineData("Java")]
        [InlineData("C#")]
        [InlineData("Python")]
        public void TestStackOverflowTechnologyForName(string name)
        {
            var param = new Dictionary<string, string>();
            param.Add("page", "1");
            param.Add("order", "desc");
            param.Add("sort", "popular");
            param.Add("site", "stackoverflow");
            param.Add("inname", name.ToLower());

            var request = _genericRequest.ReturnJson(null, param, Method.GET, "https://api.stackexchange.com/2.2/tags");
            var technology = JsonConvert.DeserializeObject<Technology>(request);
            Assert.True(technology.items.Count > 0);
        }
    }
}
