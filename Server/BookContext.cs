﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Server
{
    public class BookContext:DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            Database.Migrate();
        }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Reviewers> Reviewers { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<BookAuthor> BookAuthors { get; set; }
        public virtual DbSet<BookCategory> BookCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookCategory>().HasKey(bc => new { bc.BookId });

            modelBuilder.Entity<BookCategory>().HasOne(b => b.Book).WithMany(bc => bc.BookCategories).HasForeignKey(b => b.BookId);


            modelBuilder.Entity<BookCategory>().HasOne(c => c.Categories).WithMany(bc => bc.BookCategories).HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<BookAuthor>().HasKey(ba => new { ba.BookId, ba.AuthorId });

            modelBuilder.Entity<BookAuthor>().HasOne(b => b.book).WithMany(bc => bc.BookAuthors).HasForeignKey(b => b.BookId);

            modelBuilder.Entity<BookAuthor>().HasOne(a => a.author).WithMany(bc => bc.BookAuthors).HasForeignKey(a => a.AuthorId);



        }


    }
}
