using Microsoft.Practices.Unity;
using RSA.Core.App_Start;
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
        public static async Task Create(RestEntities type, string url)
        {
            switch (type)
            {
                case RestEntities.Members:
                    var membersRepo = UnityConfig.GetConfiguredContainer().Resolve<IMembersRepositoryAsync<MemberDto>>();
                    await Save(membersRepo, url);
                    break;
                case RestEntities.Posts:
                    var postsRepo = UnityConfig.GetConfiguredContainer().Resolve<IPostsRepositoryAsync<PostDto>>();
                    await Save(postsRepo, url);
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
