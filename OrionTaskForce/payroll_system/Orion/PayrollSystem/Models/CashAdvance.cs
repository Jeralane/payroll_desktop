using System;

namespace PayrollSystem.Models
{
	internal class CashAdvance : IModel
	{
		public decimal CashAdvanceAmount { get; set; }

		public decimal CashAdvanceMonthly { get; set; }

		public int EmployeeId { get; set; }

		public int Id { get; set; }

		public string Name { get; set; }

		public string Remarks { get; set; }

		public int StartPayroll { get; set; }

		public string TableName
		{
			get { return "CashAdvances"; }
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
