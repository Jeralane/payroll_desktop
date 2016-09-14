using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.Models
{
	internal class Payroll:IModel
	{
		public string TableName { get { return "Payrolls"; }
			set { }
		}
		public int Id { get; set; }
		public string Name { get; set; }

		public DateTime TransactionDate { get; set; }
		public int PayrollPeriodId { get; set; }
		public int DetachmentId { get; set; }
		public int EmployeeId { get; set; }
		public decimal Rate { get; set; }
		public decimal CostOfLivingAllowance { get; set; }
		public decimal NightDifferentialRate { get; set; }
		public decimal Adjustment { get; set; }
		public decimal Incentives { get; set; }

		public decimal Days { get; set; }
		public decimal Hours { get; set; }
		public decimal OvertimeHours { get; set; }
		public decimal NightDifferentialHours { get; set; }
		public decimal LegalHolidayDays { get; set; }
		public decimal LegalHolidayOvertimeHours { get; set; }
		public decimal SpecialHolidayDays { get; set; }
		public decimal SpecialHolidayOvertimeHours { get; set; }
		
		public decimal BasicPay { get; set; }
		public decimal OvertimePay { get; set; }
		public decimal NightDifferentialPay { get; set; }
		public decimal HolidayPay { get; set; }
		public decimal ColaPay { get; set; }
		public decimal OtherPay { get; set; }

		public decimal GrossPayNoIncentives { get; set; }
		public decimal GrossPay { get; set; }
		public decimal CashAdvanceAmount { get; set; }
		public decimal Insurance { get; set; }
		public string CashBondType { get; set; }
		public decimal CashBond { get; set; }
		public int CashBondOut { get; set; }
		public string CashBondRemarks { get; set; }
		#region --- PAGIBIG ---
		public decimal PagibigContributionEES { get; set; }
		public decimal PagibigContributionERS { get; set; }
		public decimal PagibigContributionTotal { get; set; }
		public decimal PagibigLoanAmount { get; set; }
		public decimal PagibigLoan { get; set; }
		#endregion
		#region --- PHILHEALTH ---
		public decimal PhilhealthContributionEES { get; set; }
		public decimal PhilhealthContributionERS { get; set; }
		public decimal PhilhealthContributionTotal { get; set; }
		public decimal PhilhealthLoanAmount { get; set; }
		public decimal PhilhealthLoan { get; set; }
		#endregion

		#region --- SSS ---
		public decimal SssContributionEES { get; set; }
		public decimal SssContributionERS { get; set; }
		public decimal SssContributionTotal { get; set; }
		public decimal SssLoanAmount { get; set; }
		public decimal SssLoan { get; set; }
		#endregion

		public decimal TW { get; set; }
		public decimal OtherDeductions { get; set; }
		public decimal TotalDeductions { get; set; }
		public decimal NetPay { get; set; }
		public decimal ThirteenthMonthPay { get; set; }

		public int BillingId { get; set; }
		public int MiscellaneousBillingId { get; set; }
		public string RecordStatus { get; set; }

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
