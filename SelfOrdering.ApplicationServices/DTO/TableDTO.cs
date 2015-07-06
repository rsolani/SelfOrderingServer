namespace SelfOrdering.ApplicationServices.DTO
{
    public class TableDTO
    {
        public string Id { get; set; }
        public string Number { get; private set; }

        public bool IsOccupied { get; private set; }
    }
}
