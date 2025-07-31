namespace OrderProcessingSystem{

    public interface IPaymentProcessor
    {
        public bool pay(long amount);
    } 
}