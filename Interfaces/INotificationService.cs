using OrderProcessingSystem;

public interface INotificationService
{
    void sendNotification(string message, User recipient);
}