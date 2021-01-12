using SocialMedia.Core.Data;
using System.Threading.Tasks;

namespace SocialMedia.Core.Services
{
    public interface IPostService
    {
        Task InsertPost(Post post);
    }
}