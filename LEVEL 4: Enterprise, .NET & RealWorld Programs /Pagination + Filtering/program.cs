app.MapGet("/users", (int page = 1, int size = 5) =>
{
    var data = Enumerable.Range(1, 50).ToList();

    var result = data
        .Skip((page - 1) * size)
        .Take(size);

    return result;
});
