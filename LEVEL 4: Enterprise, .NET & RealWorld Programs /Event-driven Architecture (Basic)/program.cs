// Event
public class OrderCreatedEvent
{
    public int OrderId { get; set; }

    public string CustomerName { get; set; } = "";
}

// Publisher
public class OrderService
{
    public event Action<OrderCreatedEvent>? OrderCreated;

    public void CreateOrder()
    {
        var orderEvent =
            new OrderCreatedEvent
            {
                OrderId = 101,
                CustomerName = "Prerna"
            };

        Console.WriteLine("Order Created");

        OrderCreated?.Invoke(orderEvent);
    }
}

// Subscriber
public class EmailService
{
    public void SendConfirmation(
        OrderCreatedEvent orderEvent)
    {
        Console.WriteLine(
            $"Email Sent for Order: " +
            $"{orderEvent.OrderId}");
    }
}

// Main Program
var orderService = new OrderService();

var emailService = new EmailService();

orderService.OrderCreated +=
    emailService.SendConfirmation;

orderService.CreateOrder();
