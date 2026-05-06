app.Use(async (ctx, next) =>
{
    try { await next(); }
    catch (Exception e)
    {
        await ctx.Response.WriteAsync("Error");
    }
});
