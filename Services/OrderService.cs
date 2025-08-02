namespace OrderProcessingSystem {
    public class OrderService {
        private IPaymentProcessor _IPaymentProcessor;
        private INotificationService _INotificationService;
        public OrderService(IPaymentProcessor paymentService, INotificationService emailSender) {
                _IPaymentProcessor = paymentService;
                _INotificationService = emailSender;
        }

        public void placeOrder(long amount, User user){
            Order newOrder = new Order(
                amount: amount,
                userId: user.UserId
            );
            _IPaymentProcessor.pay(amount);
            _INotificationService.sendNotification("Order placed successfully", user);
            Console.WriteLine("order placed!");
            return;
        }
    }
}