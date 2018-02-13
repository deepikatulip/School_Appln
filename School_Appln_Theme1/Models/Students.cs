using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace School_Appln_Theme1.Models
{
	public class Students
	{
		[DisplayName("Student Id")]
		
		public int Student_Id { get; set; }

		[DisplayName("First Name")]
		public string First_Name  { get; set; }

		[DisplayName("Last Name")]
		public string Last_Name { get; set; }

		[DisplayName("Middle Name")]
		public string Middle_Name { get; set; }

		[DisplayName("Father's Name")]
		public string Father_Name { get; set; }

		[DisplayName("Mother's Name")]
		public string Mother_Name { get; set; }

		[DisplayName("Date Of Birth")]
		public DateTime DOB { get; set; }

		[DisplayName("Gender")]
		public int Gender { get; set; }

		[DisplayName("EMail")]
		public string Email { get; set; }

		[DisplayName("Blood Group")]
		public string Blood_Group { get; set; }

		[DisplayName("Contact Number")]
		public string Contact_Number { get; set; }

		[DisplayName("Contact Number2")]
		public string Alt_Contact_Number { get; set; }

		[DisplayName("UPLOAD")]
		public string Student_Photo { get; set; }

	}
}