﻿using Microsoft.EntityFrameworkCore;
using PetshopApi.Models;

namespace PetshopApi.Context
{
    public class PetDbContext:DbContext
    {
        public PetDbContext(DbContextOptions<PetDbContext>options): base(options)
        {
        }


        public DbSet<Pet>Pets { get; set; }

    }
}
