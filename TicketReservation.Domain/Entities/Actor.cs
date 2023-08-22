using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservation.Domain.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Bio { get; set; }

        public List<ActorSpectacle> ActorSpectacles { get; set; }
    }
}
