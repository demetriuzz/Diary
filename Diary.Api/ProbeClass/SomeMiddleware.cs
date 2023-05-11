namespace Diary.Api.ProbeClass
{
    // единица конвейера
    public class SomeMiddleware
    {

        private readonly RequestDelegate next;
        private string pattern;

        // 1 условие
        public SomeMiddleware(RequestDelegate next, string pattern)
        {
            this.next = next;
            this.pattern = pattern;
        }

        // 2 условие
        public async Task Invoke(HttpContext context)
        {
            string? token = context.Request.Query["token"];
            if (token is null || token != pattern)
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync($"Token {token} invalid!");
            }
            else
            {
                await next.Invoke(context);
            }
        }

    }

}
