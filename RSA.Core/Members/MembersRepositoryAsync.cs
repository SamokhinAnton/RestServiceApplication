using Dapper;
using RSA.Core.Members.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA.Core.Members
{
    public class MembersRepositoryAsync : RepositoryAsync<MemberDto>,
        IMembersRepositoryAsync<MemberDto> 
    {
        public override async Task CreateAsync(MemberDto model)
        {
            var sql = "exec [dbo].[CreateMember] @name, @email, @phone";
            var props = new { name = model.Name, email = model.Email, phone = model.Phone };
            using (IDbConnection db = CreateConnection())
            {
                await db.ExecuteAsync(sql, props);
            }
        }
    }
}
