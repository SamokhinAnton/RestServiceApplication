using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using RestServiceApplication.Demo;
using RSA.Core.Utilities.Helpers;
using Microsoft.Practices.Unity;
using RestServiceApplication.App_Start;

namespace RestServiceApplication
{
    class Program
    {
        static void Main(string[] args)
       {
            foreach (var item in DemoData.Data)
            {
                RepositoryHelper.Create(item.Type, item.Url).Wait();
            }
        }
    }
}
