using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDienDanTinTuc.Models
{
    public class Theme
    {
        public int Id { get; set; }
        public string ThemeName { get; set; }
        public bool Status { get; set; }
        public List<Post> Posts { get; set; }
    }
}
