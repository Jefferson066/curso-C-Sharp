using System;
using System.Collections.Generic;
using System.Text;
using S14Interface.Entities;


namespace S14Interface.Service {
    class PaymentService {
        public int NumberInstallments { get; set; }
        private ITaxService _taxService;
        public PaymentService(int numberInstallments, ITaxService taxService) {
            NumberInstallments = numberInstallments;
            _taxService = taxService;
        }

        public void ProcessInstallmente(Contract contract) { }
    }
}
