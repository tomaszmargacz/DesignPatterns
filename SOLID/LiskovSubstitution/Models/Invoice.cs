using System;
using System.Collections.Generic;
using System.Linq;

namespace LiskovSubstitution.Models
{
    public class Invoice
    {
        //COMPANY
        //BILL TO
        //SHIP TO
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public List<InvoicePosition> Positions { get; set; }
        public double PriceTotal { get { return Positions?.Sum(s => s.Amount) ?? 0; } }
    }
}
