namespace OrderProcessingSystem {
    public class StripePaymentProcessor : IPaymentProcessor {
        protected override bool pay(long amount){
            console.WriteLine($"paid {amount} using stripe");
            return true;
        }   
    }
}