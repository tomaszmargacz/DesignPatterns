namespace LiskovSubstitution.Models
{
    public class InvoicePosition
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Amount { get { return UnitPrice * Quantity; } }
    }
}
