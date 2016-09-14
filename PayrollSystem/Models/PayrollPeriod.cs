using System;
using DatabaseLibrary;

namespace PayrollSystem.Models
{
    public class PayrollPeriod : AbstractModel
    {
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged("Description"); }
        }

        private DateTime _fromDate;

        public DateTime FromDate
        {
            get { return _fromDate; }
            set { _fromDate = value; OnPropertyChanged("FromDate"); }
        }

        private DateTime _toDate;

        public DateTime ToDate
        {
            get { return _toDate; }
            set { _toDate = value; OnPropertyChanged("ToDate"); }
        }

        private int _periodId;

        public int PeriodId
        {
            get { return _periodId; }
            set { _periodId = value; OnPropertyChanged("PeriodId"); }
        }

        private int _thisMonth;

        public int ThisMonth
        {
            get { return _thisMonth; }
            set { _thisMonth = value; OnPropertyChanged("ThisMonth"); }
        }

        private int _thisYear;

        public int ThisYear
        {
            get { return _thisYear; }
            set { _thisYear = value; OnPropertyChanged("ThisYear"); }
        }

        private int _workingDays;

        public int WorkingDays
        {
            get { return _workingDays; }
            set { _workingDays = value; OnPropertyChanged("WorkingDays"); }
        }

        private string _remarks;

        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; OnPropertyChanged("Remarks"); }
        }

        private bool _isPosted;

        public bool IsPosted
        {
            get { return _isPosted; }
            set { _isPosted = value; OnPropertyChanged("IsPosted"); }
        }

        public void GenerateAttributes()
        {
            ThisMonth = FromDate.Month;
            ThisYear = FromDate.Year;
            WorkingDays = ToDate.Subtract(FromDate).Days + 1;
            Description = string.Format("{0} {1}-{2}, {3}", FromDate.ToString("MMMM"),
                                                   FromDate.Day, ToDate.Day,
                                                   FromDate.Year);
        }

        public override DatabaseLibrary.ActionResult Validate()
        {
            if (string.IsNullOrEmpty(Description))
                return new DatabaseLibrary.ActionResult(false, "Description is required.");

            if (FromDate >= ToDate)
                return new DatabaseLibrary.ActionResult(false, "To Date must be later than From Date.");

            return base.Validate();
        }
    }
}