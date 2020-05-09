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
          new Term { TermID = 7, Name = "STAT", Definition = "immediately" },
          new Term { TermID = 8, Name = "pt", Definition = "patient" },
          new Term { TermID = 9, Name = "Pt", Definition = "patient" },
          new Term { TermID = 10, Name = "PT", Definition = "Physical Therapist" },
          new Term { TermID = 11, Name = "c̅", Definition = "with" },
          new Term { TermID = 12, Name = "ā", Definition = "before" },
          new Term { TermID = 13, Name = "p̄", Definition = "after" },
          new Term { TermID = 14, Name = "MD", Definition = "Medical Doctor" },
          new Term { TermID = 15, Name = "RN", Definition = "Registered Nurse" },
          new Term { TermID = 16, Name = "Sx", Definition = "Surgery" },
          new Term { TermID = 17, Name = "sx", Definition = "surgery" },
          new Term { TermID = 18, Name = "HTN", Definition = "hypertension" },
          new Term { TermID = 19, Name = "DM", Definition = "diabetes mellitus" },
          new Term { TermID = 20, Name = "RTKA", Definition = "right total knee arthroplasty" },
          new Term { TermID = 21, Name = "LTKA", Definition = "left total knee arthroplasty" },
          new Term { TermID = 22, Name = "CXR", Definition = "chest x-ray" },
          new Term { TermID = 23, Name = "ED", Definition = "Emergency Department" },
          new Term { TermID = 24, Name = "A&O", Definition = "alert and oriented" },
          new Term { TermID = 25, Name = "A&Ox1", Definition = "alert and oriented x 1" },
          new Term { TermID = 26, Name = "A&Ox2", Definition = "alert and oriented x 2" },
          new Term { TermID = 27, Name = "A&Ox3", Definition = "alert and oriented x 3" },
          new Term { TermID = 28, Name = "A&Ox4", Definition = "alert and oriented x 4" },
          new Term { TermID = 29, Name = "pnc", Definition = "penicillin" }
        );
    }
  }
}