using System;


namespace MedicalStoreManagement
{
    abstract class Person
    {
        private String _name;

        public Person(String name)
        {
            this._name = name;
        }

        public String getName()
        {
            return _name;
        }

        public abstract void showAllInformation();
    }
}
