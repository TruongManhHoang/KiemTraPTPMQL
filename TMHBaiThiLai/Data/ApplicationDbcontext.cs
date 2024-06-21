using Microsoft.EntityFrameworkCore;
using TMHBaiThiLai.Models;

namespace MvcMovie.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    // public DbSet<Person> Persons { get; set;}
    // public DbSet<Employee> Employees { get; set;}
    public DbSet<Student> Students { get; set; }

}
