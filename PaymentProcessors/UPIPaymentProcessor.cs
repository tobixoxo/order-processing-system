namespace OrderProcessingSystem{
    public class UPIPaymentProcessor : IPaymentProcessor {
        public bool pay(long amount){
            Console.WriteLine($"paid {amount} using UPI");
            return true;
        }
    }
}