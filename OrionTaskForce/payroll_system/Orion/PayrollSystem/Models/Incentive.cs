using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.Models
{
	internal class Incentive : IModel
	{
		public int DetachmentId { get; set; }

		public int EmployeeId { get; set; }

		public int Id { get; set; }

		public decimal Incentives { get; set; }

		public string Name { get; set; }

		public string Remarks { get; set; }

		public int StartPayrollId { get; set; }

		public string TableName
		{
			get { return "Incentives"; }
			set { }
		}
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
