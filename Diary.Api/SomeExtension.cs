namespace Diary.Api
{
    public static class SomeExtension
    {
        // проверка числа (метод расширения!)
        public static IApplicationBuilder CheckToken(this IApplicationBuilder applicationBuilder, string pattern)
        {
            return applicationBuilder.UseMiddleware<SomeMiddleware>(pattern);
        }
    }
}
