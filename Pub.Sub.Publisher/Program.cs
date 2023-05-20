using StackExchange.Redis;

ConnectionMultiplexer connection = await ConnectionMultiplexer.ConnectAsync("localhost:1453");

ISubscriber redis = connection.GetSubscriber();

while(true)
{
    Console.WriteLine("Message : ");
    string message = Console.ReadLine();
    await redis.PublishAsync("myChannel",message);
}