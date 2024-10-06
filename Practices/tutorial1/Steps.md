# Tutorial 1 - "Hello World" project - using C#

1.下载安装 Erlang/OTP

Erlang/OTP Version

https://www.erlang.org/downloads

<br/>

2.下载安装 RabbitMQ

https://www.rabbitmq.com/docs/install-windows#downloads

<br/>

3.Enable rabbitmq_management 插件

<br/>

以**管理员权限**打开 cmd, 输入以下命令：
```bash
cd C:\Program Files\RabbitMQ Server\rabbitmq_server-4.0.2\sbin

C:\Program Files\RabbitMQ Server\rabbitmq_server-4.0.2\sbin>rabbitmq-plugins.bat enable rabbitmq_management
```



4.关闭 RabbitMQ 服务然后重启

```bash
C:\Program Files\RabbitMQ Server\rabbitmq_server-4.0.2\sbin>net stop rabbitmq

C:\Program Files\RabbitMQ Server\rabbitmq_server-4.0.2\sbin>net start rabbitmq
```

<br/>

5.浏览器中打开 http://localhost:15672
初始的用户名密码都为 guest

<br/>

6.创建 C# 项目

```bash
dotnet new console -n Send --framework "net6.0" --use-program-main

dotnet new console -n Receive --framework "net6.0" --use-program-main
```

<br/>

7.创建 solution
将 Send project 和 Receive project 放入同一文件夹下。
使用Visual Studio 2022打开 Send project，然后将 Receive project 加入同一个 solution。

<br/>

8.更新 Send 和 Receive 逻辑的 C#代码
先将Send project 下的Program.cs 文件重命名为 Send.cs，并将代码替换为以下内容：

```csharp
using RabbitMQ.Client;
using System.Text;

namespace Send
{
    internal class Send
    {
        private static void Main(string[] args)
        {
            var factory = new ConnectionFactory { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(queue: "hello",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            const string message = "Hello World!";
            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: string.Empty,
                             routingKey: "hello",
                             basicProperties: null,
                             body: body);
            Console.WriteLine($" [x] Sent: {message}");

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}
```

<br/>

再将Receive project 下的 Program.cs 文件重命名为 Receive.cs，并将代码替换为以下内容：

```csharp
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Receive
{
    internal class Receive
    {
        private static void Main(string[] args)
        {
            var factory = new ConnectionFactory { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(queue: "hello",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            Console.WriteLine(" [*] Waiting for messages.");

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine($" [x] Received: {message}");
            };
            channel.BasicConsume(queue: "hello",
                                 autoAck: true,
                                 consumer: consumer);

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}
```

<br/>

9.编译 solution

<br/>

10.用浏览器访问: http://localhost:15672/#/queues/%2F/hello

<br/>

---

如下命令，可以创建一个新用户。

```bash
rabbitmqctl add_user <userName> <password>
```



命令示例：

```bash
rabbitmqctl add_user root 123456
```



如下命令，可以设置`<userName>`为管理员。

```bash
rabbitmqctl set_user_tags <userName> administrator
```



命令示例：

```bash
rabbitmqctl set_user_tags root administrator
```



如下命令，可以赋予用户所有权限。

```bash
rabbitmqctl set_permissions -p / <userName> '.*' '.*' '.*'
```



命令示例：

```bash
rabbitmqctl set_permissions -p / root '.*' '.*' '.*'
```



如下命令，可以在后台启动 RabbitMQ。

```bash
rabbitmq-server -detached
```
