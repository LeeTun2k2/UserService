using MediatR;
using UserService.Core.Interfaces;

namespace UserService.Core.Notifications;
public class KafkaNotificationHandler<TNotification>(IKafkaProducer kafkaProducer) : INotificationHandler<TNotification> where TNotification : INotification
{

  public async Task Handle(TNotification notification, CancellationToken cancellationToken)
  {
    await kafkaProducer.ProduceAsync(notification);
  }
}
