using Microsoft.EntityFrameworkCore;

namespace ReadMyBrainAPI.Models
{
  public class ReadMyBrainAPIContext : DbContext
  {
    public ReadMyBrainAPIContext(DbContextOptions<ReadMyBrainAPIContext> options)
        : base(options)
    {
    }

    public DbSet<Term> Terms { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Term>()
        .HasData(
          new Term { TermID = 1, Name = "M", Definition = "Male" },
          new Term { TermID = 2, Name = "F", Definition = "Female" },
          new Term { TermID = 3, Name = "Hx", Definition = "History of" },
          new Term { TermID = 4, Name = "hx", Definition = "history of" },
          new Term { TermID = 5, Name = "Ax", Definition = "Allergy of" },
          new Term { TermID = 6, Name = "DNR", Definition = "Do Not Resuscitate" },
          new Term { TermID = 7, Name = "dnr", Definition = "Do Not Resuscitate" },
          new Term { TermID = 8, Name = "pt", Definition = "patient" },
          new Term { TermID = 9, Name = "Pt", Definition = "patient" },
          new Term { TermID = 10, Name = "PT", Definition = "Physical Therapist" },
          new Term { TermID = 11, Name = "c̅", Definition = "with" }  
        );
    }
  }
}