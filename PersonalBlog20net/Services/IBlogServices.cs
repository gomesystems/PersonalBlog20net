using PersonalBlog20net.Models;
using System.Collections.Generic;

namespace PersonalBlog20net.Services
{
    public interface IBlogServices
    {
        List<BlogPost> GetLatestPosts();
        string GetPostText(string link);
    }
}


