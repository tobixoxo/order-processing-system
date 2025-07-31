using System.Guid;

namespace OrderProcessingSystem
{
    public class Order {
        public string orderid;
        public long amount;
        public string userId;

        public Order(long amount, string userId){
            orderid = new Guid.NewGuid();
            this.amount = amount;
            this.userId = userId;
        }

    }
}