using System;

namespace PayrollSystem.Models
{
	internal class FixedDeduction : IModel
	{
		public decimal CashBondAmount { get; set; }

		public decimal CashBondBasicMin { get; set; }

		public int Id { get; set; }

		public string Name { get; set; }

		public decimal PagibigBasicMin { get; set; }

		public decimal PagibigContributionEe { get; set; }

		public decimal PagibigContributionEr { get; set; }

		public int PagibigPeriodId { get; set; }

		public decimal PhilhealthBasicMin { get; set; }

		public int PhilhealthPeriodId { get; set; }

		public decimal SssBasicMin { get; set; }

		public int SssPeriodId { get; set; }

		public string TableName
		{
			get { return "FixedDeductions"; }
			set { }
		}
		public decimal WtBasicMin { get; set; }

		public int WtPeriodId { get; set; }
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
