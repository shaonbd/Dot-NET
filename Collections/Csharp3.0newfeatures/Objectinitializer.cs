using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp3._0newfeatures
{
    public class Customer
    {
        private int _customerID;
        private string _companyName;
        private Phone _phone;
        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        public Phone Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
    }

    public class Phone
    {
        private string _countryCode;
        public string CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }
        private string _areacode;
        public string AreaCode
        {
            get { return _areacode; }
            set { _areacode = value; }
        }
        private string _phonenumber;
        public string PhoneNumber
        {
            get { return _phonenumber; }
            set { _phonenumber = value; }
        }

    }


    class Objectinitializer
    {
        static void Main(string[] args)
        {
            Customer nCustomer = new Customer()
            {
                CustomerID = 102,
                CompanyName = "nTest Corporation",
                Phone = new Phone()
                {
                    CountryCode = "+91",
                    AreaCode = "09999",
                    PhoneNumber = "999999"
                }
            };

            Console.WriteLine(nCustomer.CompanyName + " " + nCustomer.CustomerID+" "+ nCustomer.Phone.PhoneNumber);


            Console.ReadKey();



        }
    }
}
