using RabbitMQ.Client;
using System;

namespace ClassLibrary1
{
    public interface IRabbitMQConnection : IDisposable
    {
        bool isConnected { get; }
        bool TryConnect();
        IModel CreateModel();
    }
}
