using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDienDanTinTuc.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string PostName { get; set; }
        public string Content { get; set; }
        public int ThemeId { get; set; }
        public Theme Theme { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public bool Status { get; set; }
    }
}
