using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace PRPCRepositoryLib.Models
{
    //here, we extend the DbContext class with our own class 'AppDbContext'
    public class PRPCRepositoryDbContext : DbContext
    {
        //The connection string is used by the SQL Server database provider to find the database
        private const string ConnectionString = @"Data Source=C:\CIDM4390\PRPC\Data\PRPCRepository.db";

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            //Using the SQLite database provider’s UseSqlServer command sets up the options ready for creating the applications’s DBContext
            optionsBuilder.UseSqlite(ConnectionString);
        }        

        public DbSet<User> Users { get; set; }        

    }    
}