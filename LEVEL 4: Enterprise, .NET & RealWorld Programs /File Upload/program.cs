app.MapPost("/upload", async (IFormFile file) =>
{
    var path = Path.Combine("uploads", file.FileName);
    using var stream = new FileStream(path, FileMode.Create);
    await file.CopyToAsync(stream);

    return "Uploaded";
});

app.MapGet("/download", (string name) =>
{
    var path = Path.Combine("uploads", name);
    return Results.File(path);
});
