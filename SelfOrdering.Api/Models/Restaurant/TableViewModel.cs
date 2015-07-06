namespace SelfOrdering.Api.Models.Restaurant
{
    public class TableViewModel
    {
        public string Id { get; set; }
        public string Number { get; private set; }

        public bool IsOccupied { get; private set; }
    }
}
