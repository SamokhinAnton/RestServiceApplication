using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA.Core.Members
{
    public interface IMembersRepositoryAsync<T> : IRepositoryAsync<T>
        where T: new()
    {

    }
}
