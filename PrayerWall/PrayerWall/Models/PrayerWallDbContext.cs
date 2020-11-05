using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace PrayerWall.Models
{
    public class PrayerWallDbContext : DbContext
    {
        public PrayerWallDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        { }

        public DbSet<PageAccess> PageAccesses { get; set; }

       
    }

  

}
