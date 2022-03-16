using PersonalBlog20net.Extensions;
using System.ComponentModel;
namespace PersonalBlog20net.Models
{
    public class BlogPost
    {

        [DisplayName("Código do Post")]
        public int PostId { get; set; }

        [DisplayName("Titúlo")]
        public string Title { get; set; }

        [DisplayName("Descrição")]
        public string ShortDescription { get; set; }

        public string Link { get 
            { return ShortDescription.UrlFriendly(50); } 
        }
    }

}
