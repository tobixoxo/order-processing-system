namespace OrderProcessingSystem {
    public class StripePaymentProcessor : IPaymentProcessor {
            public bool pay(long amount){
            Console.WriteLine($"paid {amount} using stripe");
            return true;
        }   
    }
}