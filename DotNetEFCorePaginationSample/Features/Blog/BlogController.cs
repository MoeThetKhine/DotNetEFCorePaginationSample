namespace PresentationLayerApi.Features.Blog;

[Route("api/[controller]")]
[ApiController]
public class BlogController : BaseController
{
    private readonly BL_Blog _bL_Blog;

    public BlogController(BL_Blog bL_Blog)
    {
        _bL_Blog = bL_Blog;
    }

    #region HttpGet

    [HttpGet("{pageNo}/{pageSize}")]
    public async Task<IActionResult> GetBlogs(int pageNo, int pageSize)
    {
        try
        {
            var lst = await _bL_Blog.GetBlogs(pageNo, pageSize);
            return Content(lst);
        }
        catch (Exception ex)
        {
            return InternalServerError(ex);
        }
    }

    #endregion

}
