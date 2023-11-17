using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorTestMain.Shared;

namespace BlazorTestMain.Server.Data
{
    public class BlazorTestMainServerContext : DbContext
    {
        public BlazorTestMainServerContext (DbContextOptions<BlazorTestMainServerContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorTestMain.Shared.Game> Game { get; set; } = default!;
    }
}
