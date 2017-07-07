using RSA.Core.Posts.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace RSA.Core.Posts
{
    public class PostsRepositoryAsync : RepositoryAsync<PostDto>,
        IPostsRepositoryAsync<PostDto>
    {
        public override async Task CreateAsync(PostDto model)
        {
            var sql = $"exec [dbo].[CreatePost] @title, @body";
            var props = new { title = model.Title, body = model.Body };
            using (IDbConnection db = CreateConnection())
            {
                await db.ExecuteAsync(sql, props);
            }
        }
    }
}
