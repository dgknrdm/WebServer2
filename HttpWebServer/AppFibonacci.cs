﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI;


namespace HttpWebServer
{
    public class AppFibonacci : AppBase
    {
        private static int _firstFibonacci = 1;
        private static int _secondFibonacci = 1;      

        public override string HandleRequest(string[] parameters)
        {
            if (_isStopped)
            {
                ServerProgram.HttpRequestContext.Response.StatusCode = 404;
                string errorString = System.IO.File.ReadAllText(@"C:\WebServerRoot\Error404.html");

                return errorString;

            }

            Console.Write(_firstFibonacci + "\n" + _secondFibonacci + "\n");


            int nextFibonacci = _firstFibonacci + _secondFibonacci;

            Console.WriteLine(nextFibonacci);

            _firstFibonacci = _secondFibonacci;
            _secondFibonacci = nextFibonacci;

            return nextFibonacci.ToString();
        }
    }
}
