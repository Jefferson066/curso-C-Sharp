using System;
using System.Collections.Generic;
using System.Text;

namespace S10Exer1.Entities {
    class OutsorcedEmployee : Employee {
        public double AdditionalCharge { get; set; }

        public OutsorcedEmployee() {
        }
        public OutsorcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : 
            base(name, hours, valuePerHour) {
            AdditionalCharge = additionalCharge;
        }
        public override double Payment() {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
