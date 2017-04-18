using System;

namespace MedicalStoreManagement
{
    class Customer : Person
    {
        private String _phoneNumber;
        private Account _accountObj;

        public Customer(String phoneNumber, Account accountObj, String name) : base(name)
        {

            this._phoneNumber = phoneNumber;
            this._accountObj = accountObj;
        }

        public String getPhoneNumber()
        {
            return _phoneNumber;
        }

        public Account getAccount()
        {
            return _accountObj;
        }

        public override void showAllInformation()
        {
            Console.WriteLine("Name : {0}", getName());
            Console.WriteLine("Phone Number : {0}", getPhoneNumber());
        }
    }
}
