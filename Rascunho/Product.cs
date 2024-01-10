using System;
using System.Globalization;

namespace Rascunho
{
    class Product
    {
        private string _name;
        private double _price;
        private int _quantity;

        public Product()
        {
            _quantity = 0;
        }

        public Product(string name, double price) : this()
        {
            _name = name;
            _price = price;
        }

        public Product(string name, double price, int quantity) : this(name, price)
        {
            _quantity = quantity;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >= 3)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("The error in inserting the name");
                }
            }
        }


        public double Price
        {
            get
            {
                return _price;
            }
        }


        public int Quantity
        {
            get
            {
                return _quantity;
            }
        }


        public double TotalInStock()
        {
            return _quantity * _price;
        }

        public void AddProduct(int p)
        {
            _quantity += p;
        }

        public void RemoveProduct(int p)
        {
            _quantity -= p;
        }

        public override string ToString()
        {
            return $"{_name}, $ {_price.ToString("F2", CultureInfo.InvariantCulture)}" +
                $", {_quantity} units, total: $ {TotalInStock().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
