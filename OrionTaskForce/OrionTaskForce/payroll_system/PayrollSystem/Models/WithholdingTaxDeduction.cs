using DatabaseLibrary;

namespace PayrollSystem.Models
{
    public class WithholdingTaxDeduction : AbstractModel
    {
        private string _paymentType;
        public string PaymentType
        {
            get { return _paymentType; }
            set { _paymentType = value; OnPropertyChanged("PaymentType"); }
        }

        private int _taxGroupId;
        public int TaxGroupId
        {
            get { return _taxGroupId; }
            set { _taxGroupId = value; OnPropertyChanged("TaxGroupId"); }
        }

        private decimal _exemption1;
        public decimal Exemption1
        {
            get { return _exemption1; }
            set { _exemption1 = value; OnPropertyChanged("Exemption1"); }
        }

        private decimal _percentMultiplier1;
        public decimal PercentMultiplier1
        {
            get { return _percentMultiplier1; }
            set { _percentMultiplier1 = value; OnPropertyChanged("PercentMultiplier1"); }
        }

        private decimal _basicPayMinuend1;
        public decimal BasicPayMinuend1
        {
            get { return _basicPayMinuend1; }
            set { _basicPayMinuend1 = value; OnPropertyChanged("BasicPayMinuend1"); }
        }

        private decimal _exemption2;
        public decimal Exemption2
        {
            get { return _exemption2; }
            set { _exemption2 = value; OnPropertyChanged("Exemption2"); }
        }

        private decimal _percentMultiplier2;
        public decimal PercentMultiplier2
        {
            get { return _percentMultiplier2; }
            set { _percentMultiplier2 = value; OnPropertyChanged("PercentMultiplier2"); }
        }

        private decimal _basicPayMinuend2;
        public decimal BasicPayMinuend2
        {
            get { return _basicPayMinuend2; }
            set { _basicPayMinuend2 = value; OnPropertyChanged("BasicPayMinuend2"); }
        }

        private decimal _exemption3;
        public decimal Exemption3
        {
            get { return _exemption3; }
            set { _exemption3 = value; OnPropertyChanged("Exemption3"); }
        }

        private decimal _percentMultiplier3;
        public decimal PercentMultiplier3
        {
            get { return _percentMultiplier3; }
            set { _percentMultiplier3 = value; OnPropertyChanged("PercentMultiplier3"); }
        }

        private decimal _basicPayMinuend3;
        public decimal BasicPayMinuend3
        {
            get { return _basicPayMinuend3; }
            set { _basicPayMinuend3 = value; OnPropertyChanged("BasicPayMinuend3"); }
        }

        private decimal _exemption4;
        public decimal Exemption4
        {
            get { return _exemption4; }
            set { _exemption4 = value; OnPropertyChanged("Exemption4"); }
        }

        private decimal _percentMultiplier4;
        public decimal PercentMultiplier4
        {
            get { return _percentMultiplier4; }
            set { _percentMultiplier4 = value; OnPropertyChanged("PercentMultiplier4"); }
        }

        private decimal _basicPayMinuend4;
        public decimal BasicPayMinuend4
        {
            get { return _basicPayMinuend4; }
            set { _basicPayMinuend4 = value; OnPropertyChanged("BasicPayMinuend4"); }
        }

        private decimal _exemption5;
        public decimal Exemption5
        {
            get { return _exemption5; }
            set { _exemption5 = value; OnPropertyChanged("Exemption5"); }
        }

        private decimal _percentMultiplier5;
        public decimal PercentMultiplier5
        {
            get { return _percentMultiplier5; }
            set { _percentMultiplier5 = value; OnPropertyChanged("PercentMultiplier5"); }
        }

        private decimal _basicPayMinuend5;
        public decimal BasicPayMinuend5
        {
            get { return _basicPayMinuend5; }
            set { _basicPayMinuend5 = value; OnPropertyChanged("BasicPayMinuend5"); }
        }

        private decimal _exemption6;
        public decimal Exemption6
        {
            get { return _exemption6; }
            set { _exemption6 = value; OnPropertyChanged("Exemption6"); }
        }

        private decimal _percentMultiplier6;
        public decimal PercentMultiplier6
        {
            get { return _percentMultiplier6; }
            set { _percentMultiplier6 = value; OnPropertyChanged("PercentMultiplier6"); }
        }

        private decimal _basicPayMinuend6;
        public decimal BasicPayMinuend6
        {
            get { return _basicPayMinuend6; }
            set { _basicPayMinuend6 = value; OnPropertyChanged("BasicPayMinuend6"); }
        }

        private decimal _exemption7;
        public decimal Exemption7
        {
            get { return _exemption7; }
            set { _exemption7 = value; OnPropertyChanged("Exemption7"); }
        }

        private decimal _percentMultiplier7;
        public decimal PercentMultiplier7
        {
            get { return _percentMultiplier7; }
            set { _percentMultiplier7 = value; OnPropertyChanged("PercentMultiplier7"); }
        }

        private decimal _basicPayMinuend7;
        public decimal BasicPayMinuend7
        {
            get { return _basicPayMinuend7; }
            set { _basicPayMinuend7 = value; OnPropertyChanged("BasicPayMinuend7"); }
        }

        private decimal _exemption8;
        public decimal Exemption8
        {
            get { return _exemption8; }
            set { _exemption8 = value; OnPropertyChanged("Exemption8"); }
        }

        private decimal _percentMultiplier8;
        public decimal PercentMultiplier8
        {
            get { return _percentMultiplier8; }
            set { _percentMultiplier8 = value; OnPropertyChanged("PercentMultiplier8"); }
        }

        private decimal _basicPayMinuend8;
        public decimal BasicPayMinuend8
        {
            get { return _basicPayMinuend8; }
            set { _basicPayMinuend8 = value; OnPropertyChanged("BasicPayMinuend8"); }
        }

    }

}
