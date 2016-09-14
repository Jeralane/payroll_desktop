using DatabaseLibrary;

namespace PayrollSystem.Models
{
    [TableName("billings")]
    public class Billing : AbstractModel
    {
        private string _billingType;

        [ColumnName("billing_type")]
        public string BillingType
        {
            get { return _billingType; }
            set { _billingType = value; OnPropertyChanged("BillingType"); }
        }

        private int _billingNumber;

        [ColumnName("billing_number")]
        public int BillingNumber
        {
            get { return _billingNumber; }
            set { _billingNumber = value; OnPropertyChanged("BillingNumber"); }
        }

        private int _detachmentId;

        [ColumnName("detachment_id")]
        public int DetachmentId
        {
            get { return _detachmentId; }
            set { _detachmentId = value; OnPropertyChanged("DetachmentId"); }
        }

        private int _payrollPeriodId;

        [ColumnName("payroll_period_id")]
        public int PayrollPeriodId
        {
            get { return _payrollPeriodId; }
            set { _payrollPeriodId = value; OnPropertyChanged("PayrollPeriodId"); }
        }

        private decimal _monthlyContractAmount;

        [ColumnName("monthly_contract_amount")]
        public decimal MonthlyContractAmount
        {
            get { return _monthlyContractAmount; }
            set { _monthlyContractAmount = value; OnPropertyChanged("MonthlyContractAmount"); }
        }

        private decimal _agencyFee;

        [ColumnName("agency_fee")]
        public decimal AgencyFee
        {
            get { return _agencyFee; }
            set { _agencyFee = value; OnPropertyChanged("AgencyFee"); }
        }

        private decimal _agencyVatFee;

        [ColumnName("agency_vat_fee")]
        public decimal AgencyVatFee
        {
            get { return _agencyVatFee; }
            set { _agencyVatFee = value; OnPropertyChanged("AgencyVatFee"); }
        }

        private decimal _agencyFeeTotal;

        [ColumnName("agency_fee_total")]
        public decimal AgencyFeeTotal
        {
            get { return _agencyFeeTotal; }
            set { _agencyFeeTotal = value; OnPropertyChanged("AgencyFeeTotal"); }
        }

        private decimal _ewt;

        [ColumnName("ewt")]
        public decimal Ewt
        {
            get { return _ewt; }
            set { _ewt = value; OnPropertyChanged("Ewt"); }
        }

        private decimal _netAgencyFee;

        [ColumnName("net_agency_fee")]
        public decimal NetAgencyFee
        {
            get { return _netAgencyFee; }
            set { _netAgencyFee = value; OnPropertyChanged("NetAgencyFee"); }
        }

        private decimal _totalEmployeeSalary;

        [ColumnName("total_employee_salary")]
        public decimal TotalEmployeeSalary
        {
            get { return _totalEmployeeSalary; }
            set { _totalEmployeeSalary = value; OnPropertyChanged("TotalEmployeeSalary"); }
        }

        private decimal _totalAmountCollectable;

        [ColumnName("total_amount_collectable")]
        public decimal TotalAmountCollectable
        {
            get { return _totalAmountCollectable; }
            set { _totalAmountCollectable = value; OnPropertyChanged("TotalAmountCollectable"); }
        }

    }

}
