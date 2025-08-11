using OrderProcessingSystem;
ConsoleLogger consoleLogger = ConsoleLogger.GetInstance();

UPIPaymentProcessor upi = new UPIPaymentProcessor(consoleLogger);
StripePaymentProcessor stripe = new StripePaymentProcessor(consoleLogger);
EmailSender emailSender = new EmailSender(consoleLogger);
SMSSender smsSender = new SMSSender(consoleLogger);

consoleLogger.LogInfo("Order Processing System started");
consoleLogger.LogInfo("Order Processing System started");

User user = new User
(
    name : "Sanjeev Singh",
    email: "johndoe@gmail.com",
    contactNumber: "9000090000"
);

OrderService oUPI = new OrderService(upi, emailSender, consoleLogger);

oUPI.placeOrder(22, user);


OrderService oStripe = new OrderService(stripe, smsSender, consoleLogger);

oStripe.placeOrder(22, user);

