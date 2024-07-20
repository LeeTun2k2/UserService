namespace UserService.Infrastructure.Kafka.Config;

public class KafkaSettings
{
  public string BootstrapServers { get; set; } = string.Empty;
  public string Topic { get; set; } = string.Empty;
}
