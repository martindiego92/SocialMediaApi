using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Core.Data;
using SocialMedia.Core.DTOs;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infrastucture.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;
        public PostController(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            var posts = await _postRepository.GetPosts();
            var postsDtos = _mapper.Map<IEnumerable<PostDto>>(posts);
            return Ok(postsDtos);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(int id)
        { 
            var post = await _postRepository.GetPost(id);
            var postDto = _mapper.Map<PostDto>(post);
            return Ok(postDto);
        }
        [HttpPost]
        public async Task<IActionResult> Posts(PostDto postDto)
        {
            var post = _mapper.Map<Post>(postDto);
            await _postRepository.InsertPost(post);
            return Ok(post);
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id , PostDto postDto)
        {
            var post = _mapper.Map<Post>(postDto);
            post.PostId = id;
            await _postRepository.UpdatePost(post);
            return Ok(post);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _postRepository.DeletePost(id);
            return Ok(result);
        }

    }
}
