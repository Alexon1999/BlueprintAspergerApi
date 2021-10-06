using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BlueprintAspergerApi.Models
{
  public class BPAContext : DbContext
  {
    public DbSet<User> Users { get; set; }
    public DbSet<Message> Messages { get; set; }

    public BPAContext() : base()
    {
    }

    // protected override void OnModelCreating(DbModelBuilder modelBuilder)
    // {
    //   // configures one-to-many relationship
    //   modelBuilder.Entity<Student>()
    //       .HasRequired<Grade>(s => s.CurrentGrade)
    //       .WithMany(g => g.Students)
    //       .HasForeignKey<int>(s => s.CurrentGradeId);
    // }
  }

}