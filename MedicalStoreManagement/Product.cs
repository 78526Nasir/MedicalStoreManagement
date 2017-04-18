using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement
{
    class Product
    {
        private String _productID;
        private String _productName;
        private String _productType;
        private double _price;
        private String _productCompanyName;

        public Product(String productID, String productName, String productType, double price, String productCompanyName)
        {
            this._productID = productID;
            this._productName = productName;
            this._productType = productType;
            this._price = price;
            this._productCompanyName = productCompanyName;
        }


        public String getProductID()
        {
            return _productID;
        }

        public String getProductName()
        {
            return _productName;
        }

        public String getProductType()
        {
            return _productType;
        }


        public double getPrice()
        {
            return _price;
        }

        public String getProductCompanyName()
        {
            return _productCompanyName;
        }

        public void showProductInformation()
        {
            Console.WriteLine("Product Information");
            Console.WriteLine("Product ID : {0}" , getProductID());
            Console.WriteLine("Product Name :{0} " , getProductName());
            Console.WriteLine("Product Type: {0}" , getProductType());
            Console.WriteLine("Price : {0} " , getPrice());
            Console.WriteLine("Product Company Name : {0}" , getProductCompanyName());
        }
    }
}
