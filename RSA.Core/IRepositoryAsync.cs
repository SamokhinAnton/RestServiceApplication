using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA.Core
{
    public interface IRepositoryAsync<T> 
        where T : new()
    {
        Task CreateAsync(T model);
        Task<IEnumerable<T>> GetAll(string url);
    }
}
