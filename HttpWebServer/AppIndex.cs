﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpWebServer
{
    class AppIndex : AppBase
    {

        public override string HandleRequest(string[] parameters)
        {
          
            if  (_isStopped)
            {
                // TODO: dogukan - return 404
                throw new NotImplementedException();
            }

            string responseString = System.IO.File.ReadAllText(@"C:\WebServerRoot\index.html");

            return responseString;
        }
    }
}
