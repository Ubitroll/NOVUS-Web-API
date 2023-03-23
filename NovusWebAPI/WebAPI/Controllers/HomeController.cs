using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    // ../api/Home
    public class HomeController : ApiController
    {
        private string[] S = { "apple", "banana", "orange" };

        public string[] Get()
        { 
            return S; 
        }

        // ../api/Home/{id}
        public string Get(int id)
        {
            return S[id];
        }
    }
}
