using Diary.Api;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

// 1
// app.MapGet("/", () => "Hello World!");

// 2
// app.UseWelcomePage();

// 3
/* app.Run(async (context) =>
{
    await context.Response.WriteAsync("---");
});
*/

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
app.CheckToken("12345");
app.Run(async (context) => await context.Response.WriteAsync("Hello! Index page."));

app.Run();
