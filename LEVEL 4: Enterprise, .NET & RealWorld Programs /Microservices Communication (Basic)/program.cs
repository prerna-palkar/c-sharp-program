using System.Net.Http.Json;

HttpClient client = new HttpClient();

var products = await client.GetFromJsonAsync<List<Product>>(
    "https://localhost:5001/api/products");

foreach (var product in products!)
{
    Console.WriteLine(
        $"{product.Id} - {product.Name}");
}

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = "";
}
