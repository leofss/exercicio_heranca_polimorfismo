using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_heranca_polimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufacDate  { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(DateTime manufacDate, string name, double price)
            :base(name, price)
        {
            ManufacDate = manufacDate;
        }

        public override string priceTag()
        {
            return base.priceTag() + $" usado ({ManufacDate})";
        }
    }
}
