﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Identity;
//Microsoft.AspNetCore.Identity.EntityFrameworkCore

//namespace DotNet5.IdentityLogic
//{
//    public class AppDbContext : IdentityDbContext
//    {
//        public AppDbContext(DbContextOptions<AppDbContext> options)
//            : base(options)
//        {
//        }

//        public DbSet<Employee> Employees { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);
//            modelBuilder.Seed();
//        }
//    }
//}
