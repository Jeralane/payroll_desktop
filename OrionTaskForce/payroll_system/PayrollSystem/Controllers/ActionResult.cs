using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.Models
{
	internal class ActionResult
	{
		public bool Success { get; set; }
		public string Message { get; set; }

		public ActionResult(bool success, string message)
		{
			Success = success;
			Message = message;
		}
	}
}
