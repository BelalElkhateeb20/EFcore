using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFcore.Models
{
    public class Blog
    {
        public int Id { get; set; }
        
        public string Url{get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [NotMapped]
        public List<Post> Posts { get; set; }


    }
}
