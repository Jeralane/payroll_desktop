using System;
using DatabaseLibrary;

namespace PayrollSystem.Models
{
    public class Employee : AbstractModel
    {
        private int _employeeStatusId;

        public int EmployeeStatusId
        {
            get { return _employeeStatusId; }
            set { _employeeStatusId = value; OnPropertyChanged("EmployeeStatusId"); }
        }

        private string _issuedIdNumber;

        public string IssuedIdNumber
        {
            get { return _issuedIdNumber; }
            set { _issuedIdNumber = value; OnPropertyChanged("IssuedIdNumber"); }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; OnPropertyChanged("LastName"); }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; OnPropertyChanged("FirstName"); }
        }

        private string _middleName;

        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; OnPropertyChanged("MiddleName"); }
        }

        private DateTime _dateApplied;

        public DateTime DateApplied
        {
            get { return _dateApplied; }
            set { _dateApplied = value; OnPropertyChanged("DateApplied"); }
        }

        private DateTime _dateHired;

        public DateTime DateHired
        {
            get { return _dateHired; }
            set { _dateHired = value; OnPropertyChanged("DateHired"); }
        }

        private DateTime _dateEnd;

        public DateTime DateEnd
        {
            get { return _dateEnd; }
            set { _dateEnd = value; OnPropertyChanged("DateEnd"); }
        }

        private string _badgeNumber;

        public string BadgeNumber
        {
            get { return _badgeNumber; }
            set { _badgeNumber = value; OnPropertyChanged("BadgeNumber"); }
        }

        private DateTime _birthDate;

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; OnPropertyChanged("BirthDate"); }
        }

        private string _birthPlace;

        public string BirthPlace
        {
            get { return _birthPlace; }
            set { _birthPlace = value; OnPropertyChanged("BirthPlace"); }
        }

        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; OnPropertyChanged("Gender"); }
        }

        private string _nationality;

        public string Nationality
        {
            get { return _nationality; }
            set { _nationality = value; OnPropertyChanged("Nationality"); }
        }

        private string _religion;

        public string Religion
        {
            get { return _religion; }
            set { _religion = value; OnPropertyChanged("Religion"); }
        }

        private string _age;

        public string Age
        {
            get { return _age; }
            set { _age = value; OnPropertyChanged("Age"); }
        }

        private string _civilStatus;

        public string CivilStatus
        {
            get { return _civilStatus; }
            set { _civilStatus = value; OnPropertyChanged("CivilStatus"); }
        }

        private string _landLineNumber;

        public string LandLineNumber
        {
            get { return _landLineNumber; }
            set { _landLineNumber = value; OnPropertyChanged("LandLineNumber"); }
        }

        private string _cellPhoneNumber;

        public string CellPhoneNumber
        {
            get { return _cellPhoneNumber; }
            set { _cellPhoneNumber = value; OnPropertyChanged("CellPhoneNumber"); }
        }

        private string _emailAddress;

        public string EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; OnPropertyChanged("EmailAddress"); }
        }

        private string _currentAddress;

        public string CurrentAddress
        {
            get { return _currentAddress; }
            set { _currentAddress = value; OnPropertyChanged("CurrentAddress"); }
        }

        private string _permanentAddress;

        public string PermanentAddress
        {
            get { return _permanentAddress; }
            set { _permanentAddress = value; OnPropertyChanged("PermanentAddress"); }
        }

        private string _elementarySchoolName;

        public string ElementarySchoolName
        {
            get { return _elementarySchoolName; }
            set { _elementarySchoolName = value; OnPropertyChanged("ElementarySchoolName"); }
        }

        private int _elementaryYearAttended;

        public int ElementaryYearAttended
        {
            get { return _elementaryYearAttended; }
            set { _elementaryYearAttended = value; OnPropertyChanged("ElementaryYearAttended"); }
        }

        private string _elementaryMerits;

        public string ElementaryMerits
        {
            get { return _elementaryMerits; }
            set { _elementaryMerits = value; OnPropertyChanged("ElementaryMerits"); }
        }

        private string _highSchoolName;

        public string HighSchoolName
        {
            get { return _highSchoolName; }
            set { _highSchoolName = value; OnPropertyChanged("HighSchoolName"); }
        }

        private int _highSchoolYearAttended;

        public int HighSchoolYearAttended
        {
            get { return _highSchoolYearAttended; }
            set { _highSchoolYearAttended = value; OnPropertyChanged("HighSchoolYearAttended"); }
        }

        private string _highSchoolMerits;

        public string HighSchoolMerits
        {
            get { return _highSchoolMerits; }
            set { _highSchoolMerits = value; OnPropertyChanged("HighSchoolMerits"); }
        }

        private string _collegeSchoolName;

        public string CollegeSchoolName
        {
            get { return _collegeSchoolName; }
            set { _collegeSchoolName = value; OnPropertyChanged("CollegeSchoolName"); }
        }

        private int _collegeYearAttended;

        public int CollegeYearAttended
        {
            get { return _collegeYearAttended; }
            set { _collegeYearAttended = value; OnPropertyChanged("CollegeYearAttended"); }
        }

        private string _collegeMerits;

        public string CollegeMerits
        {
            get { return _collegeMerits; }
            set { _collegeMerits = value; OnPropertyChanged("CollegeMerits"); }
        }

        private string _collegeCourse;

        public string CollegeCourse
        {
            get { return _collegeCourse; }
            set { _collegeCourse = value; OnPropertyChanged("CollegeCourse"); }
        }

        private string _higherStudiesSchoolName;

        public string HigherStudiesSchoolName
        {
            get { return _higherStudiesSchoolName; }
            set { _higherStudiesSchoolName = value; OnPropertyChanged("HigherStudiesSchoolName"); }
        }

        private int _higherStudiesYearAttended;

        public int HigherStudiesYearAttended
        {
            get { return _higherStudiesYearAttended; }
            set { _higherStudiesYearAttended = value; OnPropertyChanged("HigherStudiesYearAttended"); }
        }

        private string _higherStudiesMerits;

        public string HigherStudiesMerits
        {
            get { return _higherStudiesMerits; }
            set { _higherStudiesMerits = value; OnPropertyChanged("HigherStudiesMerits"); }
        }

        private string _higherStudiesCourse;

        public string HigherStudiesCourse
        {
            get { return _higherStudiesCourse; }
            set { _higherStudiesCourse = value; OnPropertyChanged("HigherStudiesCourse"); }
        }

        private string _vocationalSchoolName;

        public string VocationalSchoolName
        {
            get { return _vocationalSchoolName; }
            set { _vocationalSchoolName = value; OnPropertyChanged("VocationalSchoolName"); }
        }

        private int _vocationalYearAttended;

        public int VocationalYearAttended
        {
            get { return _vocationalYearAttended; }
            set { _vocationalYearAttended = value; OnPropertyChanged("VocationalYearAttended"); }
        }

        private string _vocationalMerits;

        public string VocationalMerits
        {
            get { return _vocationalMerits; }
            set { _vocationalMerits = value; OnPropertyChanged("VocationalMerits"); }
        }

        private string _vocationalCourse;

        public string VocationalCourse
        {
            get { return _vocationalCourse; }
            set { _vocationalCourse = value; OnPropertyChanged("VocationalCourse"); }
        }

        private int _taxGroupId;

        public int TaxGroupId
        {
            get { return _taxGroupId; }
            set { _taxGroupId = value; OnPropertyChanged("TaxGroupId"); }
        }

        private string _taxIdentificationNumber;

        public string TaxIdentificationNumber
        {
            get { return _taxIdentificationNumber; }
            set { _taxIdentificationNumber = value; OnPropertyChanged("TaxIdentificationNumber"); }
        }

        private string _socialSecurityNumber;

        public string SocialSecurityNumber
        {
            get { return _socialSecurityNumber; }
            set { _socialSecurityNumber = value; OnPropertyChanged("SocialSecurityNumber"); }
        }

        private string _pagibigNumber;

        public string PagibigNumber
        {
            get { return _pagibigNumber; }
            set { _pagibigNumber = value; OnPropertyChanged("PagibigNumber"); }
        }

        private string _philhealthNumber;

        public string PhilhealthNumber
        {
            get { return _philhealthNumber; }
            set { _philhealthNumber = value; OnPropertyChanged("PhilhealthNumber"); }
        }

        private string _company1Name;

        public string Company1Name
        {
            get { return _company1Name; }
            set { _company1Name = value; OnPropertyChanged("Company1Name"); }
        }

        private DateTime _company1DateEmployed;

        public DateTime Company1DateEmployed
        {
            get { return _company1DateEmployed; }
            set { _company1DateEmployed = value; OnPropertyChanged("Company1DateEmployed"); }
        }

        private string _company1Location;

        public string Company1Location
        {
            get { return _company1Location; }
            set { _company1Location = value; OnPropertyChanged("Company1Location"); }
        }

        private string _company1Position;

        public string Company1Position
        {
            get { return _company1Position; }
            set { _company1Position = value; OnPropertyChanged("Company1Position"); }
        }

        private string _company1ReasonLeaving;

        public string Company1ReasonLeaving
        {
            get { return _company1ReasonLeaving; }
            set { _company1ReasonLeaving = value; OnPropertyChanged("Company1ReasonLeaving"); }
        }

        private string _company2Name;

        public string Company2Name
        {
            get { return _company2Name; }
            set { _company2Name = value; OnPropertyChanged("Company2Name"); }
        }

        private DateTime _company2DateEmployed;

        public DateTime Company2DateEmployed
        {
            get { return _company2DateEmployed; }
            set { _company2DateEmployed = value; OnPropertyChanged("Company2DateEmployed"); }
        }

        private string _company2Location;

        public string Company2Location
        {
            get { return _company2Location; }
            set { _company2Location = value; OnPropertyChanged("Company2Location"); }
        }

        private string _company2Position;

        public string Company2Position
        {
            get { return _company2Position; }
            set { _company2Position = value; OnPropertyChanged("Company2Position"); }
        }

        private string _company2ReasonLeaving;

        public string Company2ReasonLeaving
        {
            get { return _company2ReasonLeaving; }
            set { _company2ReasonLeaving = value; OnPropertyChanged("Company2ReasonLeaving"); }
        }

        private string _illnessAllergiesSpecify;

        public string IllnessAllergiesSpecify
        {
            get { return _illnessAllergiesSpecify; }
            set { _illnessAllergiesSpecify = value; OnPropertyChanged("IllnessAllergiesSpecify"); }
        }

        private string _emergencyNotifyPerson;

        public string EmergencyNotifyPerson
        {
            get { return _emergencyNotifyPerson; }
            set { _emergencyNotifyPerson = value; OnPropertyChanged("EmergencyNotifyPerson"); }
        }

        private string _emergencyNotifyRelation;

        public string EmergencyNotifyRelation
        {
            get { return _emergencyNotifyRelation; }
            set { _emergencyNotifyRelation = value; OnPropertyChanged("EmergencyNotifyRelation"); }
        }

        private string _emergencyNotifyAddress;

        public string EmergencyNotifyAddress
        {
            get { return _emergencyNotifyAddress; }
            set { _emergencyNotifyAddress = value; OnPropertyChanged("EmergencyNotifyAddress"); }
        }

        private string _emergencyNotifyTelephone;

        public string EmergencyNotifyTelephone
        {
            get { return _emergencyNotifyTelephone; }
            set { _emergencyNotifyTelephone = value; OnPropertyChanged("EmergencyNotifyTelephone"); }
        }

        private string _criminalCaseSpecify;

        public string CriminalCaseSpecify
        {
            get { return _criminalCaseSpecify; }
            set { _criminalCaseSpecify = value; OnPropertyChanged("CriminalCaseSpecify"); }
        }

        private DateTime _criminalCaseDate;

        public DateTime CriminalCaseDate
        {
            get { return _criminalCaseDate; }
            set { _criminalCaseDate = value; OnPropertyChanged("CriminalCaseDate"); }
        }

        private string _convictedSpecify;

        public string ConvictedSpecify
        {
            get { return _convictedSpecify; }
            set { _convictedSpecify = value; OnPropertyChanged("ConvictedSpecify"); }
        }

        private DateTime _convictedDate;

        public DateTime ConvictedDate
        {
            get { return _convictedDate; }
            set { _convictedDate = value; OnPropertyChanged("ConvictedDate"); }
        }

        private string _reference1Name;

        public string Reference1Name
        {
            get { return _reference1Name; }
            set { _reference1Name = value; OnPropertyChanged("Reference1Name"); }
        }

        private string _reference1Address;

        public string Reference1Address
        {
            get { return _reference1Address; }
            set { _reference1Address = value; OnPropertyChanged("Reference1Address"); }
        }

        private string _reference1Telephone;

        public string Reference1Telephone
        {
            get { return _reference1Telephone; }
            set { _reference1Telephone = value; OnPropertyChanged("Reference1Telephone"); }
        }

        private string _reference2Name;

        public string Reference2Name
        {
            get { return _reference2Name; }
            set { _reference2Name = value; OnPropertyChanged("Reference2Name"); }
        }

        private string _reference2Address;

        public string Reference2Address
        {
            get { return _reference2Address; }
            set { _reference2Address = value; OnPropertyChanged("Reference2Address"); }
        }

        private string _reference2Telephone;

        public string Reference2Telephone
        {
            get { return _reference2Telephone; }
            set { _reference2Telephone = value; OnPropertyChanged("Reference2Telephone"); }
        }

        private string _license;

        public string License
        {
            get { return _license; }
            set { _license = value; OnPropertyChanged("License"); }
        }

        private DateTime _licenseDate;

        public DateTime LicenseDate
        {
            get { return _licenseDate; }
            set { _licenseDate = value; OnPropertyChanged("LicenseDate"); }
        }

        private DateTime _licenseDueDate;

        public DateTime LicenseDueDate
        {
            get { return _licenseDueDate; }
            set { _licenseDueDate = value; OnPropertyChanged("LicenseDueDate"); }
        }

        private string _licenseActive;

        public string LicenseActive
        {
            get { return _licenseActive; }
            set { _licenseActive = value; OnPropertyChanged("LicenseActive"); }
        }

        public override DatabaseLibrary.ActionResult Validate()
        {
            if (string.IsNullOrEmpty(FirstName))
                return new DatabaseLibrary.ActionResult(false, "First Name is required.");

            if (string.IsNullOrEmpty(LastName))
                return new DatabaseLibrary.ActionResult(false, "Last Name is required.");

            return base.Validate();
        }
    }
}