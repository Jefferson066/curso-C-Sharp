using System;
using System.Collections.Generic;
using System.Text;

namespace S10Exer2.Entities {
    class ImportedProduct : Product {
        public double CustomsFree { get; set; }

        public ImportedProduct() {
        }

        public ImportedProduct(string name, double price, double customsFree) : base(name, price) {
            CustomsFree = customsFree;
        }

        public double TotalPrice() {
            return Price + CustomsFree;
        }
        public override string PriceTag() {
            double a = Price + CustomsFree;
            return Name + " $ " + TotalPrice() + " ( Customs fee:" + CustomsFree + ")";
        }
    }
}
