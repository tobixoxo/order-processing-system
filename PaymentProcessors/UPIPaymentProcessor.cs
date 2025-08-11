namespace OrderProcessingSystem{
    public class UPIPaymentProcessor : IPaymentProcessor {
        private ILogger _logger;

        public UPIPaymentProcessor(ILogger logger)
        {
            _logger = logger;
        }
        public bool pay(long amount)
        {
            _logger.LogInfo($"Processing payment of {amount} using UPI.");
            // Simulate payment processing logic here
            Console.WriteLine($"paid {amount} using UPI");
            return true;
        }
    }
}