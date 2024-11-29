namespace Apisemana12.Models
{
    public class Detail
    {
        public int DetailId { get; set; }
        public int ProductId { get; set; }
        public int InvoiceId { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
        public float SubTotal { get; set; }
        public bool Enabled { get; set; }

    }
}
