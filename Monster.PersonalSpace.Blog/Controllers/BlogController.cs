using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Monster.PersonalSpace.Blog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public sealed class BlogController : ControllerBase
    {
        private readonly ILogger<BlogController> _logger;

        public BlogController(ILogger<BlogController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "content")]
        public IEnumerable<object> GetBlogContent([FromQuery] string blogId)
        {
            const string logInfo = "visiting blog file, file id is {BlogId}";
            _logger.LogInformation(logInfo, blogId);
            return null;
        }
    }
}