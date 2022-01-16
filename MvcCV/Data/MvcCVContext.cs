#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcCV.Models;

namespace MvcCV.Data
{
    public class MvcCVContext : DbContext
    {
        public MvcCVContext (DbContextOptions<MvcCVContext> options)
            : base(options)
        {
        }

        public DbSet<MvcCV.Models.Companies> companies { get; set; }
    }
}
