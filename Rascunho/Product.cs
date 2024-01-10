using System;
using System.Globalization;

namespace Rascunho
{
    class Product
    {
        private string _name;
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public Product()
        {
            Quantity = 0;
        }

        public Product(string name, double price) : this()
        {
            _name = name;
            Price = price;
        }

        public Product(string name, double price, int quantity) : this(name, price)
        {
            Quantity = quantity;
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

        public double TotalInStock()
        {
            return Quantity * Price;
        }

        public void AddProduct(int p)
        {
            Quantity += p;
        }

        public void RemoveProduct(int p)
        {
            Quantity -= p;
        }

        public override string ToString()
        {
            return $"{_name}, $ {Price.ToString("F2", CultureInfo.InvariantCulture)}" +
                $", {Quantity} units, total: $ {TotalInStock().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
