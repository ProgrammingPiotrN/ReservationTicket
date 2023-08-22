using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservation.Domain.Entities
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }

        public Spectacle Spectacle { get; set; }
        public int Amount { get; set; }


        public string ShoppingCartId { get; set; }
    }
}
