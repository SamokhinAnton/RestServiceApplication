using RSA.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestServiceApplication.Demo
{
    public static class DemoData
    {
        public static IEnumerable<DemoServiceTable> Data = new List<DemoServiceTable>()
        {
            new DemoServiceTable() {Url = "https://jsonplaceholder.typicode.com/users", Type = RestEntities.Members},
            new DemoServiceTable() {Url = "https://jsonplaceholder.typicode.com/posts", Type = RestEntities.Posts }
        };

    }
}
