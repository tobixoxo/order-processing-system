using OrderProcessingSystem;

public class SMSSender : INotificationService
{
    public void sendNotification(string message, User user)
    {
        // here the recipent is a phone number
        Console.WriteLine($" {message} - SMS Sent to - {user.ContactNumber}");
    }
}