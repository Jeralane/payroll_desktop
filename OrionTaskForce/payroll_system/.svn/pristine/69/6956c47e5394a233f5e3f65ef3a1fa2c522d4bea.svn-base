using System.Collections.Generic;
using System.ComponentModel;

namespace PayrollSystem.Models
{
    public sealed class Address : INotifyPropertyChanged
    {
        private string _street;
        public string Street
        {
            get { return _street; }
            set { _street = value; OnPropertyChanged("Street"); }
        }

        private string _barangay;
        public string Barangay
        {
            get { return _barangay; }
            set { _barangay = value; OnPropertyChanged("Barangay"); }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; OnPropertyChanged("City"); }
        }

        private string _province;
        public string Province
        {
            get { return _province; }
            set { _province = value; OnPropertyChanged("Province"); }
        }

        private string _country = "Philippines";
        public string Country
        {
            get { return _country; }
            set { _country = value; OnPropertyChanged("Country"); }
        }

        private string _zipCode;
        public string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; OnPropertyChanged("ZipCode"); }
        }

        private string _mailingAddress;
        public string MailingAddress
        {
            get { return _mailingAddress; }
            set { _mailingAddress = value; OnPropertyChanged("MailingAddress"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Address()
        {}

        public Address(Employer model)
        {
            Street = model.Street;
            Barangay = model.Barangay;
            City = model.City;
            ZipCode = model.ZipCode;
            Province = model.Province;
            Country = model.Country;
            MailingAddress = ToMailingAddress();
        }


        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) 
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string ToMailingAddress()
        {
            //return base.ToString();
            //Name
            //Unit Number, House/Building/Street Number + Street Name
            //Barangay/District Name, City/Municipality
            //Postal Code + Metro Manila
            //Country
            string splitter;
            var addressDetails = new List<string>();

            // 1st line
            if (!string.IsNullOrEmpty(Street))
            {
                addressDetails.Add(Street);
            }
            // 2nd line
            if (!string.IsNullOrEmpty(Barangay) || !string.IsNullOrEmpty(City))
            {
                splitter = "";
                if (!string.IsNullOrEmpty(Barangay) && !string.IsNullOrEmpty(City))
                {
                    splitter = ", ";
                }
                addressDetails.Add(string.Format("{0}{1}{2}", Barangay, splitter, City));
            }

            // 3rd line
            if (!string.IsNullOrEmpty(ZipCode) || !string.IsNullOrEmpty(Province))
            {
                splitter = "";
                if (!string.IsNullOrEmpty(ZipCode) && !string.IsNullOrEmpty(Province))
                {
                    splitter = " ";
                }
                addressDetails.Add(string.Format("{0}{1}{2}", ZipCode, splitter, Province));
            }

            if (!string.IsNullOrEmpty(Country))
            {
                addressDetails.Add(Country);
            }
            var addressBuilder = new System.Text.StringBuilder();
            for (int i = 0; i < addressDetails.Count; i++)
            {
                if (i == addressDetails.Count - 1)
                {
                    addressBuilder.Append(addressDetails[i]);
                }
                else
                {
                    addressBuilder.AppendLine(addressDetails[i]);
                }
            }
            return addressBuilder.ToString();
        }

        public override string ToString()
        {
            //return base.ToString();
            //Name
            //Unit Number, House/Building/Street Number + Street Name
            //Barangay/District Name, City/Municipality
            //Postal Code + Metro Manila
            //Country
            string splitter;
            var addressDetails = new List<string>();

            // 1st line
            if (!string.IsNullOrEmpty(Street))
            {
                addressDetails.Add(Street);
            }           
            // 2nd line
            if (!string.IsNullOrEmpty(Barangay) || !string.IsNullOrEmpty(City))
            {
                splitter = "";
                if (!string.IsNullOrEmpty(Barangay) && !string.IsNullOrEmpty(City))
                {
                    splitter = ", ";
                }
                addressDetails.Add(string.Format("{0}{1}{2}", Barangay, splitter, City));
            }

            // 3rd line
            if (!string.IsNullOrEmpty(ZipCode) || !string.IsNullOrEmpty(Province))
            {
                splitter = "";
                if (!string.IsNullOrEmpty(ZipCode) && !string.IsNullOrEmpty(Province))
                {
                    splitter = " ";
                }
                addressDetails.Add(string.Format("{0}{1}{2}", ZipCode, splitter, Province));
            }
            
            if (!string.IsNullOrEmpty(Country))
            {
                addressDetails.Add(Country);
            }
            var addressBuilder = new System.Text.StringBuilder();
            for (int i = 0; i < addressDetails.Count; i++)
            {
                if(i == addressDetails.Count-1)
                {
                    addressBuilder.Append(addressDetails[i]);
                }else
                {
                    addressBuilder.Append(addressDetails[i] + ", ");
                }
            }
            return addressBuilder.ToString();
        }
    }
}
