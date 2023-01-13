using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DBTestAppRound2.Models;

namespace DBTestAppRound2.Data
{
    public class DBTestAppRound2Context : DbContext
    {
        public DBTestAppRound2Context (DbContextOptions<DBTestAppRound2Context> options)
            : base(options)
        {
        }

        public DbSet<DBTestAppRound2.Models.Item> Items { get; set; } = default!;
    }
}
