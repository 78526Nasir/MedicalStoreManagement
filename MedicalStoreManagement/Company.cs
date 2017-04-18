using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement
{
    class Company
    {
        private String _companyID;
        private String _companyName;

        public Company(String companyName, String companyID)
        {
            this._companyID = companyID;
            this._companyName = companyName;
        }


        public String getCompanyName()
        {
            return _companyName;
        }

        public String getCompanyID()
        {
            return _companyID;
        }

    }
}
