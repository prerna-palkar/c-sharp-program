// Command
public record CreateProductCommand(
    string Name,
    decimal Price);

// Command Handler
public class CreateProductHandler
{
    public void Handle(
        CreateProductCommand command)
    {
        Console.WriteLine(
            $"Product Created: " +
            $"{command.Name} - {command.Price}");
    }
}

// Query
public record GetProductsQuery();

// Query Handler
public class GetProductsHandler
{
    public List<string> Handle(
        GetProductsQuery query)
    {
        return new List<string>
        {
            "Laptop",
            "Phone",
            "Tablet"
        };
    }
}

// Main Program
var createHandler =
    new CreateProductHandler();

createHandler.Handle(
    new CreateProductCommand(
        "Laptop",
        55000));

var queryHandler =
    new GetProductsHandler();

var products =
    queryHandler.Handle(
        new GetProductsQuery());

foreach (var product in products)
{
    Console.WriteLine(product);
}
