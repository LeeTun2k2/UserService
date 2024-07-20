namespace UserService.Core.Interfaces;
public interface IKafkaProducer
{
  Task ProduceAsync<T>(T message);
}
