using System;

namespace PayrollSystem.Models
{
	internal class PayrollPeriod : IModel
	{
		public DateTime DateBegin { get; set; }

		public DateTime DateEnd { get; set; }

		public int Id { get; set; }

		public bool IsPosted { get; set; }

		public string Name { get; set; }

		public int PeriodId { get; set; }

		public string Remarks { get; set; }

		public string TableName { get { return "PayrollPeriods"; }
			set { }
		}
		public int ThisMonth { get; set; }
		public int ThisYear { get; set; }
		public int WorkDays { get; set; }

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
