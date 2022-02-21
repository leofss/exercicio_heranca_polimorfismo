using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_heranca_polimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double Fees { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(double fees, string name, double price)
            : base(name, price)
        {
            Fees = fees;
        }

        public override string priceTag()
        {
            return base.priceTag() + $"taxa {Fees}";
        }


    }
}
