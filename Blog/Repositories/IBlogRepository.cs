using BlogLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog
{
    public interface IBlogRepository
    {
        IList<Post> Posts(int pageNo, int pageSize);
        int TotalPosts();
    }
}