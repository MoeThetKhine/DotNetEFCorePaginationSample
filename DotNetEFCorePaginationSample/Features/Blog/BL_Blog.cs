using Models.Features.Blog;

namespace PresentationLayerApi.Features.Blog
{
    public class BL_Blog
    {
        private readonly DA_Blog _dA_Blog;
        public BL_Blog(DA_Blog dA_Blog)
        {
            _dA_Blog = dA_Blog;
        }
        #region GetBlogs
        public async Task<BlogListResponseModel> GetBlogs(int pageNo, int pageSize)
        {
            if (pageNo <= 0)
                throw new Exception("Page No is Invalid");
            if (pageSize <= 0)
                throw new Exception("Page Size is Invalid");
            return await _dA_Blog.GetBlogs(pageNo, pageSize);
        }
        #endregion

    }
}
