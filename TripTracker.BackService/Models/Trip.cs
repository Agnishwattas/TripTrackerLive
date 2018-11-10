using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.BackService.Models
{
    public class Trip
    {
        public int Id { get; set; }

        /// <summary>
        /// Destination of the trip
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the trip
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Date of the start of the trip
        /// </summary>
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// Date of the end of the trip
        /// </summary>
        public DateTimeOffset EndDate { get; set; }
    }
}
