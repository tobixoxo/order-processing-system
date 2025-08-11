namespace OrderProcessingSystem {
    public class OrderService {
        private IPaymentProcessor _IPaymentProcessor;
        private ILogger _logger;
        private INotificationService _INotificationService;
        public OrderService(IPaymentProcessor paymentService, INotificationService emailSender, ILogger logger)
        {
            _IPaymentProcessor = paymentService;
            _INotificationService = emailSender;
            _logger = logger;
        }

        public void placeOrder(long amount, User user){
            Order newOrder = new Order(
                amount: amount,
                userId: user.UserId
            );
            _logger.LogInfo($"Placing order for user {user.Name} with amount {amount}");
            try
            {
                _IPaymentProcessor.pay(amount);
                _INotificationService.sendNotification("Order placed successfully", user);
                Console.WriteLine("order placed!");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to place order : {ex.Message}");
            }

            return;
        }
    }
}