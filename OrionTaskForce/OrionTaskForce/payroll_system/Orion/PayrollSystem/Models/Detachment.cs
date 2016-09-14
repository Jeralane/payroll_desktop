using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.Models
{
	internal class Detachment : IModel
	{
		public string Address { get; set; }

		public decimal Adjustment { get; set; }

		public decimal CostOfLivingAllowance { get; set; }

		public int ExcemptBilling { get; set; }

		public int ExemptTax { get; set; }

		public decimal HoursPerDay { get; set; }

		public int Id { get; set; }

		public decimal MonthlyAllowance { get; set; }

		public decimal MonthlyContractAmount { get; set; }

		public decimal MonthlyRate { get; set; }

		public string Name { get; set; }

		public decimal NightDifferentialRate { get; set; }

		public int NumberOfGuards { get; set; }

		public decimal Rate { get; set; }

		public string Remarks { get; set; }

		public string TableName
		{
			get { return "Detachments"; }
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
