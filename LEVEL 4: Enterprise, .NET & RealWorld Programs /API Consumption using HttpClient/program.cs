using System.Net.Http;

HttpClient client = new HttpClient();
string res = await client.GetStringAsync("https://api.github.com");
Console.WriteLine(res);
