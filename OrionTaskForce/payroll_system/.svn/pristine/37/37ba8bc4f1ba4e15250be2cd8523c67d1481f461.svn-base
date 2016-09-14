using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.Models
{
	internal class WithholdingTaxDeduction : IModel
	{
		public string TableName { get; set; }
		public int Id { get; set; }
		public string Name { get; set; }
		public PaymentType PaymentType { get; set; }
		public TaxGroup TaxGroup { get; set; }

		public Exemption Exemption { get; set; }


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

	enum PaymentType
	{
		Daily,
		Weekly,
		SemiMonthly,
		Monthly,
	}

	class Exemption
	{
		public decimal Amount { get; set; }
		public decimal PercentMultiplier { get; set; }
		public decimal BasicPayMinuend { get; set; }
	}
}
