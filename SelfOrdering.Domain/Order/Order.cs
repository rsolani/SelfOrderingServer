using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SelfOrdering.Domain.Contracts;

namespace SelfOrdering.Domain.Order
{   public enum OrderStatus
    {
        Open = 1,
        Finished = 2
    }
    
    public class Order : MongoEntityBase, IAggregateRoot
    {
        public ObjectId RestaurantId { get; private set; }

        public ObjectId TableId{ get; private set; }

        public ObjectId CustomerOwnerId { get; private set; }

        public IReadOnlyList<OrderCard> Cards { get; private set; }
        
        [BsonDateTimeOptions(DateOnly = false, Kind = DateTimeKind.Utc, Representation = BsonType.DateTime)]
        public DateTime OpeningDate { get; private set; }

        [BsonDateTimeOptions(DateOnly = false, Kind = DateTimeKind.Utc, Representation = BsonType.DateTime)]
        public DateTime FinishDate { get; private set; }

        public OrderStatus Status { get; private set; }


        public Order(ObjectId restaurantId, ObjectId tableId, ObjectId customerOwnerId)
        {
            CustomerOwnerId = customerOwnerId;
            RestaurantId = restaurantId;
            OpeningDate = DateTime.Now;
            TableId = tableId;
            Status = OrderStatus.Open;

            Cards = new List<OrderCard>();
        }
        public decimal OrderTotal
        {
            get { return Cards.Sum(x => x.OrderCardTotal); }
        }

        public int GetCardsCount()
        {
            return Cards.Count;
        }

        public void SetOrderAsFinished()
        {
            Status = OrderStatus.Finished;
            FinishDate = DateTime.Now;
        }

        public void AddCard(OrderCard card)
        {
            if (card == null)
                throw new ArgumentNullException("RemoveCard: OrderCard cannot be null");

            ((IList)Cards).Add(card);
        }
        public void RemoveCard(OrderCard card)
        {
            if (card == null)
                throw new ArgumentNullException("RemoveCard: OrderCard not found");

            ((IList)Cards).Remove(card);
        }

    }
}
