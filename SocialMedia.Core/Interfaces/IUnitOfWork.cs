using SocialMedia.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Interfaces
{
    public interface IUnitOfWork :IDisposable
    {
        IPostRepository PostRepository{ get; }
        IRepository<User> UserRepository { get; }
        IRepository<Comment> CommentRepository { get; }
        void SaveChanges();
        Task SaveChangesAsync();


    }
}
