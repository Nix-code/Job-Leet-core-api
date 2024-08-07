using RabbitMQ.Client;
using JobLeet.WebApi.JobLeet.Core.Services.MessageBroker.Helpers;
using System.Text;

namespace JobLeet.WebApi.JobLeet.Core.Services.MessageBroker.Publisher
{
    public class RabbitMQService : IDisposable
    {
        private readonly RabbitMQServiceSetup _rabbitMQServiceSetup;
        private readonly IModel _channel;
        private readonly ILogger<RabbitMQService> _logger;
         public RabbitMQService(RabbitMQServiceSetup rabbitMQServiceSetup, ILogger<RabbitMQService> logger)
        {
            _rabbitMQServiceSetup = rabbitMQServiceSetup;
            _channel = _rabbitMQServiceSetup.GetChannel();
            _logger =  logger;

        }

       public void Dispose()
        {
            _rabbitMQServiceSetup.Dispose();
        }

        public void PublishMessage(object @event, string message){
            var eventName = @event.GetType().Name;
            

        if (string.IsNullOrEmpty(eventName))
        {
            _logger.LogWarning("No routing key found for event type '{EventType}'", eventName);
            return;
        }
            var body = Encoding.UTF8.GetBytes(message);

            _channel.BasicPublish(exchange: "messages",
                                  routingKey: eventName,
                                  basicProperties: null,
                                  body: body);
           
             _logger.LogInformation("Published message to topic '{Topic}': {Message}", eventName, message);

        }
    }
}
