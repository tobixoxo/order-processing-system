using OrderProcessingSystem;

public class SMSSender : INotificationService
{
    private ILogger _logger;

    public SMSSender(ILogger logger)
    {
        _logger = logger;
    }
    public void sendNotification(string message, User user)
    {
        _logger.LogInfo($"Sending SMS notification: {message} to {user.ContactNumber}");
        try
        {
            Console.WriteLine($" operation : {message} - sent to - {user.ContactNumber}");
        }
        catch (Exception ex)
        {
            _logger.LogError($"Failed to send SMS notification: {ex.Message}");
        }
        // here the recipent is a phone number
    }
}