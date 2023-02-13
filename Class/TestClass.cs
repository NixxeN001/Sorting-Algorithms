using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_AlgorithmsNew
{
    public class TestClass : IComparable<TestClass>
    {

        private string name = "";
        private int price;
        private int damage;
        private float range;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Damage { get => damage; set => damage = value; }
        public float Range { get => range; set => range = value; }

        public TestClass()
        {
            Name = "Test";
            Price = 0;
            Damage = 0;
            Range = 0.0f;

        }
        public TestClass(string name_, int price_, int damage_, float range_)
        {
            Name = name_;
            Price = price_;
            Damage = damage_;
            Range = range_;
        }

        public int CompareTo(TestClass? other)
        {

            if (other != null) return Name.CompareTo(other.Name);
            else return 1;
        }

        public override string ToString()
        {
            return Name + ":" + Price + ":" + Damage + ":" + Range;
        }
    }

    class PriceComaperer : IComparer<TestClass>
    {
        public int Compare(TestClass? x, TestClass? y)
        {
            if (x != null && y != null) return x.Price - y.Price;
            else return -1;
        }
    }
    class DamageComparer : IComparer<TestClass>
    {
        public int Compare(TestClass? x, TestClass? y)
        {
            if (x != null && y != null) return x.Damage - y.Damage;
            else return -1;
        }
    }
    class RangeComparer : IComparer<TestClass>
    {
        public int Compare(TestClass? x, TestClass? y)
        {
            if (x != null && y != null) return (int)(x.Range - y.Range);
            else return -1;
        }
    }
}
