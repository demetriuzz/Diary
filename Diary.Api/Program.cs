WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

// 1
// app.MapGet("/", () => "Hello World!");
// 2
app.UseWelcomePage();
// 3
/* app.Run(async (context) =>
{
    await context.Response.WriteAsync("---");
});
*/

app.Run();
