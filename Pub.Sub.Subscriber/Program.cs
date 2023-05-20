using StackExchange.Redis;

ConnectionMultiplexer connection = await ConnectionMultiplexer.ConnectAsync("localhost:1453");

ISubscriber redis = connection.GetSubscriber();


await redis.SubscribeAsync("myChannel.*", (channel, message) =>
{
    Console.WriteLine(message);
});

Console.Read();