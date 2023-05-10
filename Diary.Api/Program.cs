using Diary.Api;
using Serilog;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddTimeService();

Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

WebApplication app = builder.Build();

// 4
/* string DateAsString = "";
app.Use(async (context, next) =>
{
    Console.WriteLine("4: begin");
    DateAsString = DateTime.Now.ToShortDateString();
    // �� �������� ��������� ����������
    await next.Invoke();
    // ����� �������� ��������� ����������
    Console.WriteLine("4: end");
});
// ������������ middleware
app.Run(async context =>
{
    Console.WriteLine("5: run");
    await context.Response.WriteAsync($"Date: {DateAsString}");
    // Console.WriteLine("5: begin"); // �������� ���� ��������!
});
*/

// 5
/*
app.CheckToken("12345");
app.Run(async (context) => await context.Response.WriteAsync("Hello! Index page."));
*/

app.Run(async context =>
{
    Log.Information("��������� �������");
    var timeService = app.Services.GetService<TimeService>();
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync($"������� �����: {timeService?.GetTime()}");
});

app.Run();
