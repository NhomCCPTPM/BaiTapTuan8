using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebDienDanTinTuc.Models;

namespace WebDienDanTinTuc.Data
{
    public class WebDienDanTinTucContext : DbContext
    {
        public WebDienDanTinTucContext (DbContextOptions<WebDienDanTinTucContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<AccountType> AccountTypes { get; set; }
    }
}
