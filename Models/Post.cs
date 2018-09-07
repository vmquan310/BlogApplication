using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Picture { get; set; }
        public DateTime PostDate { get; set; }
    }
}
