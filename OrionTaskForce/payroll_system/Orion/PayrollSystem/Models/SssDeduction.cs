using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.Models
{
	internal class SssDeduction
	{
		public string TableName { get; set; }
		public int Id { get; set; }
		public string Name { get; set; }

		public decimal MonthlyRangeF { get; set; }
		public decimal MonthlyRangeR { get; set; }
		public decimal EmployeeContribution { get; set; }
		public decimal EmployerContribution { get; set; }
		public ActionResult Create()
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

		public ActionResult Delete()
		{
			throw new NotImplementedException();
		}
	}
}
