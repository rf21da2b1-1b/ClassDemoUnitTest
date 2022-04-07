using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoUnitTest.model
{
    public class Item
    {
        private int _id;
        private string _name;
        private double _price;

        public Item():this(0,"dummy", 0)
        {
        }

        public Item(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id
        {
            get => _id;
            set
            {
                CheckId(value);
                _id = value;
            }
        }

        

        public string Name
        {
            get => _name;
            set
            {
                CheckName(value);
                _name = value;
            }
        }

        

        public double Price
        {
            get => _price;
            set
            {
                CheckPrice(value);
                _price = value;
            }
        }

        

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Price)}: {Price}";
        }

        private void CheckId(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("Id must be a positive number or zero");
            }

            if (id > 10000)
            {
                throw new ArgumentException("Id can not exceed 10000");
            }

        }
        private void CheckName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("name must have a value");
            }

            if (name.Length < 3)
            {
                throw new ArgumentException("name must be at least 3 character long");
            }

        }
        private void CheckPrice(double price)
        {
            if (price < 0 || 1000000 < price)
            {
                throw new ArgumentException("price must be between 0 and 1000000 DKK");
            }

        }
    }
}
