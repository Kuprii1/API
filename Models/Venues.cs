using Newtonsoft.Json;

namespace Прототип_API.Models
{
    public class Venues
    {
        public VenueResponce[] Response { get; set; }
    }
    public class VenueResponce
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Capacity { get; set; }
        public string Surface { get; set; }
        public string Image { get; set; }
    }

}
