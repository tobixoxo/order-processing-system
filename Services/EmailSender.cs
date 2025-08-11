namespace OrderProcessingSystem {
    public class EmailSender : INotificationService {
        private ILogger _logger;

        public EmailSender(ILogger logger)
        {
            _logger = logger;
        }
        public void sendNotification(string message, User recpipient)
        {
            _logger.LogInfo($"Sending email notification: {message} to {recpipient.Email}");
            // Simulate sending email logic here
            try
            {
                Console.WriteLine($" operation: {message} - Email Sent to - {recpipient.Email}");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to send email notification: {ex.Message}");
            }
        }
    }
}