using Inlämning_2_EntityFramwork.Models;
using Microsoft.EntityFrameworkCore;

namespace Inlämning_2_EntityFramwork;

public class DBClass : DbContext
{
    private const string DatabaseName = "MHGenealogi";

    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer($@"Server=(localdb)\mssqllocaldb;Database={DatabaseName};Trusted_Connection=True;");
    }
}

//public static class InitializeDatabase
//{
//    public static void Seed()
//    {
//    }
//}