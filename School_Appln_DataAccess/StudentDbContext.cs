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
		//public DbSet<CustomerViewModel> CustomerViewModel { get; set; }
		//public DbSet<Unit> Unit { get; set; }
		//public DbSet<Billing> Billing { get; set; }
		//public DbSet<Billing_Cancelled> Billing_Cancelled { get; set; }
		//public DbSet<GSM> GSM { get; set; }
		//public DbSet<Status> Status { get; set; }
		//public DbSet<PaymentType> PaymentType { get; set; }
		//public DbSet<PaymentDetail> PaymentDetail { get; set; }
		//public DbSet<CreditNoteDetail> CreditNoteDetail { get; set; }
		//public DbSet<OpeningBalance> OpeningBalanceDetail { get; set; }




		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

			modelBuilder.Entity<Students>().HasKey(s => s.Student_Id);
			modelBuilder.Entity<StudentOtherDetails>().HasKey(s => s.Student_Id);
			//modelBuilder.Entity<ProductViewModel>().HasKey(s => s.Product_Id);
			//modelBuilder.Entity<CustomerViewModel>().HasKey(s => s.Id);
			//modelBuilder.Entity<Billing_Cancelled>().HasKey(s => s.Invoice_Id);
			//modelBuilder.Entity<Unit>().HasKey(s => s.Unit_Id);
			//modelBuilder.Entity<Billing>().HasKey(s => s.Invoice_Id);
			//modelBuilder.Entity<GSM>().HasKey(s => s.GSM_Id);
			//modelBuilder.Entity<Status>().HasKey(s => s.Status_Id);
			//modelBuilder.Entity<PaymentType>().HasKey(s => s.Payment_Id);
			//modelBuilder.Entity<PaymentDetail>().HasKey(s => s.Id);
			//modelBuilder.Entity<ProductViewModel>().Property(s => s.Price_Per_Unit).HasColumnType("Decimal").HasPrecision(18, 5);
			//modelBuilder.Entity<CreditNoteDetail>().HasKey(s => s.Id);
			//modelBuilder.Entity<OpeningBalance>().HasKey(s => s.Id);

			//modelBuilder.Entity<ProductList>().Property(s => s.Price_Per_Unit).HasColumnType("Decimal").HasPrecision(18, 5);


			//modelBuilder.Entity<User>().ToTable("User");
			//modelBuilder.Entity<Billing>().ToTable("Billing");
			//modelBuilder.Entity<ProductViewModel>().ToTable("Product");
			//modelBuilder.Entity<CustomerViewModel>().ToTable("Customer");
			//modelBuilder.Entity<User_Registration>().ToTable("UserRegistration");
			//modelBuilder.Entity<Billing_Cancelled>().ToTable("Billing_Cancelled");
			//modelBuilder.Entity<Unit>().ToTable("Unit");
			//modelBuilder.Entity<GSM>().ToTable("GSM");
			//modelBuilder.Entity<Status>().ToTable("Status");
			//modelBuilder.Entity<PaymentType>().ToTable("PaymentType");
			//modelBuilder.Entity<PaymentDetail>().ToTable("PaymentDetail");
			//modelBuilder.Entity<CreditNoteDetail>().ToTable("CreditNote_Detail");
			//modelBuilder.Entity<OpeningBalance>().ToTable("OpeningBalance");

			base.OnModelCreating(modelBuilder);
		}

	}
}
