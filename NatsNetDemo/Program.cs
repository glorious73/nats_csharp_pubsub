using NATS.Client.Core;

await using var nats = new NatsConnection();

var cts = new CancellationTokenSource();

var subscription = Task.Run(async () =>
{
    await foreach (var msg in nats.SubscribeAsync<string>(subject: "foo").WithCancellation(cts.Token))
    {
        Console.WriteLine($"Received: {msg.Data}");
    }
});

// Give subscription time to start
await Task.Delay(1000);

for (var i = 0; i < 10; i++)
{
    await nats.PublishAsync(subject: "foo", data: $"Hello, World! {i}");
}

// Give subscription time to receive messages
await Task.Delay(1000);

// Unsubscribe
cts.Cancel();

await subscription;