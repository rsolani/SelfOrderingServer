namespace SelfOrdering.Domain.Restaurant
{
    public class Table : MongoEntityBase
    {
        public string Number { get; private set; }

        public bool IsOccupied { get; private set; }
        
        public Table(string number)
        {
            Number = number;
        }

        public void SetOccupation(bool isOccupied)
        {
            IsOccupied = isOccupied;
        }
    }
}
