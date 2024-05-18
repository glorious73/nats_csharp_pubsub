using NATS.Client.Core;

await using var nats = new NatsConnection();

var cts = new CancellationTokenSource();

var subscription = Task.Run(async () =>
{
    await foreach (var msg in nats.SubscribeAsync<string>(subject: "hello").WithCancellation(cts.Token))
    {
        Console.WriteLine($"Received [{msg.Subject}]: {msg.Data}");
    }
});

// Subscription time before program disconnects
await Task.Delay(15000);

// Unsubscribe
cts.Cancel();

await subscription;