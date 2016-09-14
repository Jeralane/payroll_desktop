using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.Models
{
	internal class CashBond : IModel
	{
		public decimal CashBondAmount { get; set; }

		public decimal CashBondOut { get; set; }

		public string CashBondRemarks { get; set; }

		public int EmployeeId { get; set; }

		public int Id { get; set; }

		public string Name { get; set; }

		public string TableName
		{
			get
			{
				return "CashBonds";
			}
			set { }
		}
		public DateTime TransactionDate { get; set; }

		public string VoucherCheckNo { get; set; }
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
