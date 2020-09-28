using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab_2.Models.Toons;

    public class Toons : DbContext
    {
        public Toons (DbContextOptions<Toons> options)
            : base(options)
        {
        }

        public DbSet<lab_2.Models.Toons.People> People { get; set; }
    }
