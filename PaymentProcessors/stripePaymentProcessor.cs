namespace OrderProcessingSystem {
    public class StripePaymentProcessor : IPaymentProcessor {
        private ILogger _logger;

        public StripePaymentProcessor(ILogger logger)
        {
            _logger = logger;
        }
            public bool pay(long amount)
        {
            _logger.LogInfo($"Processing payment of {amount} using Stripe.");
            // Simulate payment processing logic here
            Console.WriteLine($"paid {amount} using stripe");
            return true;
        }   
    }
}