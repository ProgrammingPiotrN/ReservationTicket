using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservation.Domain.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public float Amount { get; set; }
        public double Price { get; set; }
        public int SpectacleId { get; set; }
        public Spectacle Spectacle { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
