using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _05_DemoEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KaradDBContext db = new KaradDBContext();
            db.Emps.Add(new Emp() { Name = "Kumar", Address = "Satara" });
            db.SaveChanges();
        }

        [Table("Emp")]

        public class Emp
        {
            [Column("No",TypeName = "int")]
            [Key]
            public int No { get; set; }

            [Column("Name", TypeName = "varchar")]
            [StringLength(50)]
            public string Name { get; set; }

            [Column("Address", TypeName = "varchar")]
            [StringLength(50)]
            public string Address { get; set; }
        }

        public class Trainer
        {
            [Key]
            public int TrainerId { get; set; }

            public string TrainerName { get; set; }

            public List<Subject> Subjects { get; set; } 
        }

        public class Subject
        {
            [Key]
            public int SubjectId { get; set; }

            public string SubjectTitle { get; set; }

            public List<Trainer> Trainers { get; set; }
        }

        public class KaradDBContext : DbContext
        {
            public DbSet<Emp> Emps { get; set; }
            public DbSet<Trainer> Trainers { get; set; }
            public DbSet<Subject> Subjects { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=KaradDB;Integrated Security=True;");
            }
        }
    }
}