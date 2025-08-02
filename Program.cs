using OrderProcessingSystem; 

UPIPaymentProcessor upi = new UPIPaymentProcessor();
StripePaymentProcessor stripe = new StripePaymentProcessor();
EmailSender emailSender = new EmailSender();
SMSSender smsSender = new SMSSender();
User user = new User
(
    name : "Sanjeev Singh",
    email: "johndoe@gmail.com",
    contactNumber: "9000090000"
);

OrderService oUPI = new OrderService(upi, emailSender);

oUPI.placeOrder(22, user);


OrderService oStripe = new OrderService(stripe, smsSender);

oStripe.placeOrder(22, user);

