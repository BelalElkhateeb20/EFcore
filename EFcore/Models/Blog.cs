using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFcore.Models
{
    public class Blog
    {
        public int Id { get; set; }
        
        public string url{get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        //public List<Post> Posts { get; set; }


    }
}
