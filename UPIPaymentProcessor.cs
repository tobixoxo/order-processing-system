namespace OrderProcessingSystem{
    public class UPIPaymentProcessor : IPaymentProcessor {
        protected override bool pay(long amount){
            Console.WriteLine($"paid {amount} using UPI");
            return true;
        }
    }
}