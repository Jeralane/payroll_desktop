using System;
using System.Collections.Generic;

namespace PayrollSystem.Models
{
	internal class Employee : IModel
	{
		public string BadgeNumber { get; set; }

		public DateTime ConvictedDate { get; set; }

		public string ConvictedSpecify { get; set; }

		public DateTime CriminalCaseDate { get; set; }

		public string CriminalCaseSpecify { get; set; }

		public DateTime DateApplied { get; set; }

		public DateTime DateEnd { get; set; }

		public DateTime DateHired { get; set; }

		public List<Education> EducationalAttainment { get; set; }

		public string EmployeeName { get; set; }

		public int EmployeeStatusId { get; set; }

		public List<Employment> EmploymentHistory { get; set; }

		public int Id { get; set; }

		public string IllnessOrAllergy { get; set; }

		public int IssuedId { get; set; }

		public string Name { get; set; }

		public string PagibigNumber { get; set; }

		public Contact PersonToNotify { get; set; }

		public string PhilhealthNumber { get; set; }

		public List<Contact> References { get; set; }

		public string SocialSecurityNumber { get; set; }

		public string TableName
		{
			get { return "Employees"; }
			set { }
		}

		public int TaxGroupId { get; set; }

		public string TaxIdentificationNumber { get; set; }

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
}
