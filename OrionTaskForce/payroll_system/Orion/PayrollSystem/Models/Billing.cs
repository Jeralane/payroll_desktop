using System;

namespace PayrollSystem.Models
{
	internal class Billing : IModel
	{
		public string TableName
		{
			get { return "Billings"; }
			set { }
		}

		public int Id { get; set; }
		public string Name { get; set; }

		public string BillingType { get; set; }

		public int BillingNumber { get; set; }

		public int DetachmentId { get; set; }

		public int PayrollPeriodId { get; set; }

		public decimal MonthlyContractAmount { get; set; }

		public decimal AgencyFee { get; set; }

		public decimal AgencyFeeVat { get; set; }

		public decimal AgencyFeeTotal { get; set; }

		public decimal EWT { get; set; }

		public decimal NetAgencyFee { get; set; }

		public decimal TotalEmployeeSalary { get; set; }

		public decimal TotalAmountCollectable { get; set; }

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
