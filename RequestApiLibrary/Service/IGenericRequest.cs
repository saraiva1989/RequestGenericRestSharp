using System;
using System.Collections.Generic;
using RestSharp;

namespace RequestApiLibrary.Service
{
    public interface IGenericRequest
    {
        string ReturnJson(Dictionary<string, string> Headers, Dictionary<string, string> Param, Method MethodType, string url);
    }
}
