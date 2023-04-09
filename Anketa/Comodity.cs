using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Anketa
{
    [Serializable]
    public class Comodity
    {
        public string name, country, weight, price, all_price;
        public Comodity(string name, string country, string price, string weight, string all_price)
        {
            this.name = name;
            this.country = country;
            this.price = price;
            this.weight = weight;
            this.all_price = all_price;
        }
        public Comodity()
        {
            
        }
        public override string ToString()
        {
            return String.Format($"   {name}                {country}                       {price}           {weight}               {all_price}");
        }
    }
}
