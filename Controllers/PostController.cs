using System;
using System.Threading.Tasks;
using AJ_Blog.Controllers.Resources;
using AJ_Blog.Core;
using AJ_Blog.Core.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
namespace AJ_Blog.Controllers
{
    [Route("/api/post")]
    public class PostController:Controller
    {
    private readonly IMapper mapper;
    private readonly IPostRepository repository;
    private readonly IUnitOfWork unitOfWork;

    public PostController(IMapper mapper, IPostRepository repository, IUnitOfWork unitOfWork)
    {
      this.unitOfWork = unitOfWork;
      this.repository = repository;
      this.mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> CreatePost([FromBody] SavePostResource postResource)
    {
      if (!ModelState.IsValid)
        return BadRequest(ModelState);

      var Post = mapper.Map<SavePostResource, Post>(postResource);
      Post.CreationDate = DateTime.Now;

      repository.Add(Post);
      await unitOfWork.CompleteAsync();

      Post = await repository.GetPost(Post.Id);

      var result = mapper.Map<Post, PostResource>(Post);

      return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePost(int id, [FromBody] SavePostResource PostResource)
    {
      if (!ModelState.IsValid)
        return BadRequest(ModelState);

      var Post = await repository.GetPost(id);

      if (Post == null)
        return NotFound();

      mapper.Map<SavePostResource, Post>(PostResource, Post);
      Post.CreationDate = DateTime.Now;

      await unitOfWork.CompleteAsync();

      Post = await repository.GetPost(Post.Id);
      var result = mapper.Map<Post, PostResource>(Post);

      return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePost(int id)
    {
      var Post = await repository.GetPost(id);

      if (Post == null)
        return NotFound();

      repository.Remove(Post);
      await unitOfWork.CompleteAsync();

      return Ok(id);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPost(int id)
    {
      var Post = await repository.GetPost(id);

      if (Post == null)
        return NotFound();

      var PostResource = mapper.Map<Post, PostResource>(Post);

      return Ok(PostResource);
    }

    [HttpGet]
    public async Task<QueryResultResource<PostResource>> GetPosts(PostQueryResource filterResource)
    {
      var filter = mapper.Map<PostQueryResource, PostQuery>(filterResource);
      var queryResult = await repository.GetPosts(filter);

      return mapper.Map<QueryResult<Post>, QueryResultResource<PostResource>>(queryResult);
    }
    }
}