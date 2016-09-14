using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.Models
{
	interface IModel
	{
		string TableName
		{
			get;
			set;
		}

		int Id { get; set; }

		string Name { get; set; }

		ActionResult Create();

		ActionResult Read();

		ActionResult Update();

		ActionResult Delete();
	}
}
