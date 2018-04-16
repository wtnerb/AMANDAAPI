﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMANDAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AMANDAPI.Data
{
    public class ImagesContext : DbContext
    {
        public ImagesContext(DbContextOptions<ImagesContext> options) : base(options) {}

        public DbSet<Image> Images { get; set; }
    }
}
