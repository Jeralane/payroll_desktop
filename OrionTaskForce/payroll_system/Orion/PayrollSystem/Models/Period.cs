using System;

namespace PayrollSystem.Models
{
	internal class Period : IModel
	{
		public int FirstDay { get; set; }

		public int Id { get; set; }

		public int LastDay { get; set; }

		public string Name { get; set; }

		public string TableName
		{
			get { return "Periods"; }
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
