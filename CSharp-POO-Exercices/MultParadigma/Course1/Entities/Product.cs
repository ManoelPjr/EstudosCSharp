using System;
using System.Globalization;

namespace Course1.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string nome, double price)
        {
            Name = nome;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    //class Product : IComparable<Product>
    //{
    //    public string Name { get; set; }
    //    public double Price { get; set; }

    //    public Product(string nome, double price)
    //    {
    //        Name = nome;
    //        Price = price;
    //    }

    //    public override string ToString()
    //    {
    //        return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
    //    }

    //    public int CompareTo(Product other)
    //    {
    //        //return Name.ToUpper().CompareTo(other.Name.ToUpper());
    //        return Price.CompareTo(other.Price);
    //    }
    //}
}
