using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA.Core.Posts
{
    public interface IPostsRepositoryAsync<T> : IRepositoryAsync<T>
        where T: new()
    {

    }
}
