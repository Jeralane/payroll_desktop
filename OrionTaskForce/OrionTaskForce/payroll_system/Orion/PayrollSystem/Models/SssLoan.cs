using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.Models
{
	internal class SssLoan : IModel
	{
		public string TableName { get; set; }
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime TransactionDate { get; set; }
		public int EmployeeId { get; set; }
		public int StartPayrollId { get; set; }
		public decimal SSSLoanAmount { get; set; }
		public decimal SSSLoanMonthly { get; set; }
		public decimal SSSLoan { get; set; }
		public string Remarks { get; set; }
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
