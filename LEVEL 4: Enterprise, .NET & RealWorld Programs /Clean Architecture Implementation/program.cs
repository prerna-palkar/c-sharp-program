// Domain Layer
public class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = "";
}

// Application Layer
public interface IProductService
{
    List<Product> GetProducts();
}

public class ProductService : IProductService
{
    public List<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop"
            },

            new Product
            {
                Id = 2,
                Name = "Phone"
            }
        };
    }
}

// Presentation Layer
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProductService,
    ProductService>();

var app = builder.Build();

app.MapGet("/products",
    (IProductService service) =>
{
    return service.GetProducts();
});

app.Run();
