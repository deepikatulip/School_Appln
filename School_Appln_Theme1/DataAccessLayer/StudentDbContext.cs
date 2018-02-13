using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using School_Appln_Theme1.Models;


namespace School_Appln_DataAccess
{
    public class StudentDbContext : DbContext
	{
		public StudentDbContext() : base("StudentDbContext")
        {
		}

		public DbSet<Student> Student { get; set; }
		public DbSet<StudentOtherDetails> Student_Other_Details { get; set; }
		



		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

			modelBuilder.Entity<Students>().HasKey(s => s.Student_Id);
			modelBuilder.Entity<StudentOtherDetails>().HasKey(s => s.Student_Id);
			
			base.OnModelCreating(modelBuilder);
		}

	}
}
