using AutoMapper;
using SocialMedia.Core.Data;
using SocialMedia.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMedia.Infrastucture.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Post, PostDto>();
            CreateMap<PostDto, Post>();
        }
    }
}
