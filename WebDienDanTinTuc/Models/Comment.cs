using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDienDanTinTuc.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public bool Status { get; set; }
    }
}
