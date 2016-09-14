using DatabaseLibrary;

namespace PayrollSystem.Models
{
    public class FixedDeduction : AbstractModel
    {
        private decimal _cashBondAmount;
        public decimal CashBondAmount
        {
            get { return _cashBondAmount; }
            set { _cashBondAmount = value; OnPropertyChanged("CashBondAmount"); }
        }

        private decimal _cashBondBasicMin;
        public decimal CashBondBasicMin
        {
            get { return _cashBondBasicMin; }
            set { _cashBondBasicMin = value; OnPropertyChanged("CashBondBasicMin"); }
        }

        private int _pagibigPeriodId;
        public int PagibigPeriodId
        {
            get { return _pagibigPeriodId; }
            set { _pagibigPeriodId = value; OnPropertyChanged("PagibigPeriodId"); }
        }

        private decimal _pagibigContributionEmployee;
        public decimal PagibigContributionEmployee
        {
            get { return _pagibigContributionEmployee; }
            set { _pagibigContributionEmployee = value; OnPropertyChanged("PagibigContributionEmployee"); }
        }

        private decimal _pagibigContributionEmployer;
        public decimal PagibigContributionEmployer
        {
            get { return _pagibigContributionEmployer; }
            set { _pagibigContributionEmployer = value; OnPropertyChanged("PagibigContributionEmployer"); }
        }

        private decimal _pagibigBasicMin;
        public decimal PagibigBasicMin
        {
            get { return _pagibigBasicMin; }
            set { _pagibigBasicMin = value; OnPropertyChanged("PagibigBasicMin"); }
        }

        private int _withholdingTaxPeriodId;
        public int WithholdingTaxPeriodId
        {
            get { return _withholdingTaxPeriodId; }
            set { _withholdingTaxPeriodId = value; OnPropertyChanged("WithholdingTaxPeriodId"); }
        }

        private decimal _withholdingTaxBasicMin;
        public decimal WithholdingTaxBasicMin
        {
            get { return _withholdingTaxBasicMin; }
            set { _withholdingTaxBasicMin = value; OnPropertyChanged("WithholdingTaxBasicMin"); }
        }

        private int _philhealthPeriodId;
        public int PhilhealthPeriodId
        {
            get { return _philhealthPeriodId; }
            set { _philhealthPeriodId = value; OnPropertyChanged("PhilhealthPeriodId"); }
        }

        private decimal _philhealthBasicMin;
        public decimal PhilhealthBasicMin
        {
            get { return _philhealthBasicMin; }
            set { _philhealthBasicMin = value; OnPropertyChanged("PhilhealthBasicMin"); }
        }

        private int _sssPeriodId;
        public int SssPeriodId
        {
            get { return _sssPeriodId; }
            set { _sssPeriodId = value; OnPropertyChanged("SssPeriodId"); }
        }

        private decimal _sssBasicMin;
        public decimal SssBasicMin
        {
            get { return _sssBasicMin; }
            set { _sssBasicMin = value; OnPropertyChanged("SssBasicMin"); }
        }

    }

}
