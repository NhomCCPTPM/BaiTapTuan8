using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDienDanTinTuc.Models
{
    public class AccountType
    {
        public int Id { get; set; }
        public string AccountTypeName { get; set; }
        public bool Status { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
