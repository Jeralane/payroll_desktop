using System;

namespace PayrollSystem.Models
{
	internal class PagibigLoan : IModel
	{
		public int EmployeeId { get; set; }

		public int Id { get; set; }

		public decimal LoanAmount { get; set; }

		public string Name { get; set; }

		public decimal PagibigLoanAmount { get; set; }

		public decimal PagibigLoanMonthly { get; set; }

		public string Remarks { get; set; }

		public int StartPayrollId { get; set; }

		public string TableName
		{
			get { return "PagibigLoans"; }
			set { }
		}

		public DateTime TransactionDate { get; set; }
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