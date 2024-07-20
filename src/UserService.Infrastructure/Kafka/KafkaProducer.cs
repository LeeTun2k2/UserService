using System.Text.Json;
using Confluent.Kafka;
using Microsoft.Extensions.Options;
using UserService.Infrastructure.Kafka.Config;
using UserService.Core.Interfaces;

namespace UserService.Infrastructure.Kafka;

public class KafkaProducer : IKafkaProducer
{
  private readonly KafkaSettings _settings;
  private readonly IProducer<Null, string> _producer;

  public KafkaProducer(IOptions<KafkaSettings> settings)
  {
    _settings = settings.Value;
    var config = new ProducerConfig { BootstrapServers = _settings.BootstrapServers };
    _producer = new ProducerBuilder<Null, string>(config).Build();
  }

  public async Task ProduceAsync<T>(T message)
  {
    var value = JsonSerializer.Serialize(message);
    await _producer.ProduceAsync(_settings.Topic, new Message<Null, string> { Value = value });
  }
}
