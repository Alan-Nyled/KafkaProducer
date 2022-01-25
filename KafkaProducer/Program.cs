using Confluent.Kafka;
using System.Net;

var config = new ProducerConfig
{
    BootstrapServers = "172.19.95.154:9092",
    ClientId = Dns.GetHostName(),
};

using (var producer = new ProducerBuilder<Null, string>(config).Build())
{
    await producer.ProduceAsync("quickstart-events", new Message<Null, string> { Value = "Her er beskeden " });
}