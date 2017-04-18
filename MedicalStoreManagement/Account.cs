using System;


namespace MedicalStoreManagement
{
    class Account
    {
        private String _name;
        private String _password;
        private String _gender;
        private int _age;

        public Account(String name, String password, String gender, int age)
        {
            this._name = name;
            this._password = password;
            this._gender = gender;
            this._age = age;
        }

        public String getName()
        {
            return _name;
        }

        public String getPassword()
        {
            return _password;
        }

        public String getGender()
        {
            return _gender;
        }

        public int getAge()
        {
            return _age;
        }

        public void showAllInformation()
        {
            Console.WriteLine("Account Info");
            Console.WriteLine("User Name : {0} " , getName());
            Console.WriteLine("Gender : {0}" , getGender());
            Console.WriteLine("Age : {0}" , getAge());
            Console.WriteLine("Password : {0}" , getPassword());
        }
    }


    
}
