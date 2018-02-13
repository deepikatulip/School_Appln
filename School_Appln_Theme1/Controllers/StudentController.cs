using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using School_Appln_Theme1.Models;
using PagedList;


namespace School_Appln_Theme1.Controllers
{
	
	public class StudentController : Controller
    {
	
		
		public ViewResult AddStudent(string sortOrder, string currentFilter, string searchString, int? page)
		{
			ViewBag.CurrentSort = sortOrder;
			ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
			ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

			if (searchString != null)
			{
				page = 1;
			}
			else
			{
				searchString = currentFilter;
			}

			ViewBag.CurrentFilter = searchString;
			var students1 = new List<Student>
			{
			new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01"),ID = 1},
			new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01"),ID = 2},
			new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01"),ID = 3},
			new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01"),ID = 4},
			new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01"),ID = 5},
			new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01"),ID = 6},
			new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01"),ID = 7},
			new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01"),ID = 8}
			};
			var students = (from s in students1
							select s).AsQueryable(); ;
			if (!String.IsNullOrEmpty(searchString))
			{
				students = students.Where(s => s.LastName.Contains(searchString)
									   || s.FirstName.Contains(searchString));
			}
			switch (sortOrder)
			{
				case "name_desc":
					students = students.OrderByDescending(s => s.LastName);
					break;
				case "Date":
					students = students.OrderBy(s => s.EnrollmentDate);
					break;
				case "date_desc":
					students = students.OrderByDescending(s => s.EnrollmentDate);
					break;
				default:  // Name ascending 
					students = students.OrderBy(s => s.LastName);
					break;
			}

			int pageSize = 4;
			int pageNumber = (page ?? 1);

			return View(students.ToPagedList(pageNumber, pageSize));
		}
		// GET: Student
		//public ActionResult Index()
		//      {

		//	return View();
		//      }

		//public ActionResult AddStudent()
		//{
		//	return View();
		//}

		public ActionResult CreateStudent()
		{
			return View();
		}

		public ActionResult StudentView()
		{
			
			return View();
		}

		public ActionResult AddStudentOtherDetails()
		{
			return View();
		}

		public ActionResult Test()
		{

			var students1 = new List<Student>
			{
			new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01"),ID = 1},
			new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01"),ID = 2},
			new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01"),ID = 3},
			new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01"),ID = 4},
			new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01"),ID = 5},
			new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01"),ID = 6},
			new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01"),ID = 7},
			new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01"),ID = 8}
			};
			return View(students1.ToList());
		}

		public ActionResult Test1()
		{
			var students1 = new List<Student>
			{
			new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01"),ID = 1},
			new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01"),ID = 2},
			new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01"),ID = 3},
			new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01"),ID = 4},
			new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01"),ID = 5},
			new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01"),ID = 6},
			new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01"),ID = 7},
			new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01"),ID = 8}
			};
			
			return View(students1.ToList());
		}

		[HttpGet]
		public JsonResult getEmployees()
		{
			var jsonData = new List<Student>
			{
			new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
			new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
			new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
			new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
			new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
			new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
			new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
			new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
			};
			return Json(jsonData, JsonRequestBehavior.AllowGet);

		}


	}
}