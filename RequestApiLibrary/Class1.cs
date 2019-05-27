using System;
using RequestApiLibrary.Service;
using RestSharp;

namespace RequestApiLibrary
{
    public class Class1
    {
        private readonly IGenericRequest _genericRequest;

        public Class1(IGenericRequest genericRequest)
        {
            _genericRequest = genericRequest;
        }

        public void teste()
        {
            var request = _genericRequest.ReturnJson(null, null, Method.GET, "http://api.londrinaweb.com.br/PUC/Paisesv2/0/1000");
            Console.WriteLine(request);
        }

    }
}

