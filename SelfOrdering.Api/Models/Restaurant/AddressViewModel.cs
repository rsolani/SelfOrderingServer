namespace SelfOrdering.Api.Models.Restaurant
{
    public class AddressViewModel
    {
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string ZipCode { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double DistanceFromUser { get; set; }
    }
}