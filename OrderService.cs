namespace OrderProcessingSystem {
    public class OrderService {
        private IPaymentProcessor _IPaymentService;
        public OrderService(IPaymentProcessor paymentService){
            _IPaymentProcessor = paymentService;
        }

        public void placeOrder(int amount, string userid){
            Order newOrder = new Order(
                amount: amount,
                userId: userid
            );
            _IPaymentProcessor.pay(amount);
            EmailSender emailService = new EmailSender();
            emailService.sendMail();
            Console.WriteLine("order placed!");
            return;
        }
    }
}