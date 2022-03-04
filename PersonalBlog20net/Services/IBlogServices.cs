using PersonalBlog20net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog20net.Services
{
    public interface IBlogService
    {
        List<BlogPost> GetLatestPosts();
        List<BlogPost> GetOlderPosts(int olderBlogPostId);
        string GetPostText(string link);
    }
}