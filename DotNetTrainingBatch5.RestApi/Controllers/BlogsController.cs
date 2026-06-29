using DotNetTrainingBatch5.Database.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetTrainingBatch5.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly AppDbContext _db = new AppDbContext();
        private object item;

        [HttpGet]
        public IActionResult GetBlogs()
        {
            var lst = _db.TblBlogs.AsNoTracking().ToList();
            AppDbContext db = new AppDbContext();
            return Ok(new {Message = "GetBlogs"});
        }

        [HttpGet("{id}")]
        public IActionResult GetBlogs(int id)
        {
            var lst = _db.TblBlogs.AsNoTracking().FirstOrDefault(x=>x.BlogId ==id);
            if (item is null)
            {
                return NotFound();
            }
            AppDbContext db = new AppDbContext();
            return Ok(new { Message = "GetBlogs" });
        }
        [HttpPost]
        public IActionResult CreateBlog(TblBlog blog)
        {
            _db.TblBlogs.Add(blog);
            _db.SaveChanges();
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateBlog(int id, TblBlog blog)
        {
            var lst = _db.TblBlogs.AsNoTracking().ToList();
            if(item is null)
            {
                return NotFound();
            }
            item.BlogTitle = blog.BlogTitle;
            item.BlogAuthor = blog.BlogAuthor;
            item.BlogContent = blog.BlogContent;
            _db.Entry 
            return Ok();
        }
        [HttpPatch]
        public IActionResult PatchBlog()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteBlog()
        {
            return Ok();
        }
    }
}
