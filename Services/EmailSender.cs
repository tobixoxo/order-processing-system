namespace OrderProcessingSystem {
    public class EmailSender : INotificationService {
        public void sendNotification(string message, User recpipient) {
            Console.WriteLine($" {message} - Email Sent to - {recpipient.Email}");
        }
    }
}