namespace SelfOrdering.Domain.Restaurant
{
    public class Address
    {
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }

        public string Suburb { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}