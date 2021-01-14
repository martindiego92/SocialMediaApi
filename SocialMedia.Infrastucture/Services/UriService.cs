using SocialMedia.Core.QueryFilters;
using SocialMedia.Infrastucture.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMedia.Infrastucture.Services
{
    public class UriService : IUriService
    {
        private readonly string _baseUri;
        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }


        public Uri GetPostPaginationUri(PostQueryFilter filter, string actionUri)
        {
            string baseUrl = $"{_baseUri}{ actionUri}";
            return new Uri(baseUrl);

        }

    }
}
