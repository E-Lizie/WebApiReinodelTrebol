using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiReinodelTrebol.Models;

namespace WebApiReinodelTrebol.Data
{
    public class WebApiReinodelTrebolContext : DbContext
    {
        public WebApiReinodelTrebolContext (DbContextOptions<WebApiReinodelTrebolContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiReinodelTrebol.Models.Request> Request { get; set; } = default!;
    }
}
