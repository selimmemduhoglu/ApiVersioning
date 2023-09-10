using Microsoft.AspNetCore.Authorization;

namespace ApiVersioning.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
    }
}
