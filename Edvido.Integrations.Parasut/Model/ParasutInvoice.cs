using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edvido.Integrations.Parasut.Model
{
    public class ParasutInvoice
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public double ExchangeRate { get; set; }
        public string Description { get; set; }
        public double NetTotal { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }
        public double OtherAmount { get; set; }
        public string OtherCurrency { get; set; }
        public double AmountInTRL { get; set; }
        public bool Cancelled { get; set; }
    }
}
