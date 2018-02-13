
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Appln_Theme1.Models
{
	public class Student 
	{
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		[Display(Name = "Enrollment Date")]
		public DateTime EnrollmentDate { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public int ID { get; set; }
		//added comments 
	}
}