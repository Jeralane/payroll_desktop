using System;

namespace PayrollSystem.Models
{
	internal class Education : IModel
	{
		public int ContactId { get; set; }

		public string Course { get; set; }

		public EducationLevel EducationLevel { get; set; }

		public int Id { get; set; }

		public string Merits { get; set; }

		public string Name { get; set; }

		public Company School { get; set; }

		public string TableName
		{
			get { return "Educations"; }
			set { }
		}

		public string YearAttended { get; set; }

		public ActionResult Create()
		{
			throw new NotImplementedException();
		}

		public ActionResult Delete()
		{
			throw new NotImplementedException();
		}

		public ActionResult Read()
		{
			throw new NotImplementedException();
		}

		public ActionResult Update()
		{
			throw new NotImplementedException();
		}
	}

	public enum EducationLevel
	{
		Elementary,
		HighSchool,
		College,
		HigherStudies,
		Vocational,
	}
}
