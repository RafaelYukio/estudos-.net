using Confluent.Kafka;

var config = new ConsumerConfig
{
    BootstrapServers = "localhost:9092",  // Endereço do Kafka no Docker
    GroupId = "meu-grupo-consumidor",     // Grupo de consumidores
    AutoOffsetReset = AutoOffsetReset.Earliest  // Começar do início das mensagens
};

// Criando o consumidor
using (var consumer = new ConsumerBuilder<Ignore, string>(config).Build())
{
    consumer.Subscribe("test");

    CancellationTokenSource cts = new CancellationTokenSource();
    Console.CancelKeyPress += (_, e) =>
    {
        e.Cancel = true;
        cts.Cancel();
    };

    try
    {
        while (!cts.Token.IsCancellationRequested)
        {
            try
            {
                var consumeResult = consumer.Consume(cts.Token);
                Console.WriteLine($"Mensagem recebida: {consumeResult.Message.Value}");
            }
            catch (ConsumeException e)
            {
                Console.WriteLine($"Erro ao consumir mensagem: {e.Error.Reason}");
            }
        }
    }
    catch (OperationCanceledException)
    {
        // Esse código será executado quando o consumo for cancelado
        Console.WriteLine("Consumo cancelado.");
    }
    finally
    {
        consumer.Close();
    }
}