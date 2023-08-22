using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservation.Domain.Entities
{
    public class ActorSpectacle
    {
        public int SpectacleId { get; set; }
        public Spectacle Spectacle { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        
    }
}
