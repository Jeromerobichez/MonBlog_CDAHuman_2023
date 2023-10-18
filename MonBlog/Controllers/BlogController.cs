using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace MonBlog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Get()
        {
            return Content("<html><body><h1>Hello, World</h1></body></html>", "text/html");
        }
        [HttpGet("/article/{id}")]
        public IActionResult GetArticle(string id)
        {
            string filePath = $"C:\\Users\\jerome\\Source\\Repos\\MonBlog_CDAHuman_2023\\MonBlog\\articles\\{id}.html";
            string contentType = "text/html";
            return File(System.IO.File.ReadAllBytes(filePath), contentType);
        }
    }
}