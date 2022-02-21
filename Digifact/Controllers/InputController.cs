using Digifact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Digifact.Controllers
{
    public class InputController : ApiController
    {
        Input dataIn = new Input();

        [HttpPost]
        public string PostConversion(Input buffer)
        {
            //Console.Write(buffer.Data);
            return buffer.Data;
        }
    }
}
