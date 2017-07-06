using Microsoft.Practices.Unity;
using RSA.Core.Members;
using RSA.Core.Members.Models;
using RSA.Core.Models;
using RSA.Core.Posts;
using RSA.Core.Posts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA.Core.Utilities.Helpers
{
    public static class RepositoryHelper
    {
        [Dependency]
        public static IMembersRepositoryAsync<MemberDto> MembersRepo { get; set; }

        [Dependency]
        public static IPostsRepositoryAsync<PostDto> PostsRepo { get; set; }

        public static async Task Create(RestEntities type, string url)
        {
            switch (type)
            {
                case RestEntities.Members:
                    await Save(MembersRepo, url);
                    break;
                case RestEntities.Posts:
                    await Save(PostsRepo, url);
                    break;
                default:
                    break;
            }
        }

        public static async Task Save<T>(IRepositoryAsync<T> repository, string url)
            where T : new() 
        {
            var data = await repository.GetAll(url);
            foreach (var item in data)
            {
                await repository.CreateAsync(item);
            }
        }
    }
}
