using Diary.Api;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddTimeService();

WebApplication app = builder.Build();

// 4
/* string DateAsString = "";
app.Use(async (context, next) =>
{
    Console.WriteLine("4: begin");
    DateAsString = DateTime.Now.ToShortDateString();
    // до передачи обработки следующему
    await next.Invoke();
    // после передачи обработки следующему
    Console.WriteLine("4: end");
});
// терминальный middleware
app.Run(async context =>
{
    Console.WriteLine("5: run");
    await context.Response.WriteAsync($"Date: {DateAsString}");
    // Console.WriteLine("5: begin"); // зависает если оставить!
});
*/

// 5
/*
app.CheckToken("12345");
app.Run(async (context) => await context.Response.WriteAsync("Hello! Index page."));
*/

app.Run(async context =>
{
    var timeService = app.Services.GetService<TimeService>();
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync($"Текущее время: {timeService?.GetTime()}");
});

app.Run();
