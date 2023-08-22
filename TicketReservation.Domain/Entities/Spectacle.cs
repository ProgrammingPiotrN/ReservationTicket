using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservation.Domain.Entities
{
    public class Spectacle
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public SpectacleCategory SpectacleCategory { get; set; }

        public List<ActorSpectacle> ActorSpectacles { get; set; }

        public int TheaterId { get; set; }
        public Theater Theater { get; set; }

        public int ProducerId { get; set; }

        public Producer Producer { get; set; }
    }
}
