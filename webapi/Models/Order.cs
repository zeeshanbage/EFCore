using System.ComponentModel.DataAnnotations;

public class Order
{
        [Key]
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public int Address_Id { get; set; }
        public int ProductId { get; set; }
        public double Amount { get; set; }
        public string? Phone { get; set; }
        public DateTime? Date { get; set; }
        public byte OrderShipped { get; set; }
        public string? TrackingNumber { get; set; }
}