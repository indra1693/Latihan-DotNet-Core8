using Microsoft.EntityFrameworkCore;

namespace sampleDataDummy.Models;

public class Personal
{
    public int Id { get; set; }
    public string Nama { get; set; }
    public int IdGender { get; set; }
    public string IdHobi { get; set; }
    public int Umur { get; set; }
}

public class PersonalDbContext : DbContext
{
    public PersonalDbContext(DbContextOptions<PersonalDbContext> options ): base(options) { }
    
    public DbSet<Personal> Personals { get; set; }
}