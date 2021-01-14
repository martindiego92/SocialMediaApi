using SocialMedia.Core.QueryFilters;
using System;

namespace SocialMedia.Infrastucture.Interfaces
{
    public interface IUriService
    {
        Uri GetPostPaginationUri(PostQueryFilter filter, string actionUri);
       
    }
}