using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RSA.Core
{
    public class RepositoryAsync<T> : IRepositoryAsync<T>
        where T: new()
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public virtual Task CreateAsync(T model)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<T>> GetAll(string url)
        {
            using (WebClient w = new WebClient())
            {
                w.Headers.Add("Content-Type", "text/plain; charset=utf-8");
                return JsonConvert.DeserializeObject<IEnumerable<T>>(await w.DownloadStringTaskAsync(url));
            }
        }
    }
}
