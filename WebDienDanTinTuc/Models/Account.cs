using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDienDanTinTuc.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public int AccountTypeId { get; set; }
        public AccountType AccountType { get; set; }
        public bool Status { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Post> Posts { get; set; }
    }
}
