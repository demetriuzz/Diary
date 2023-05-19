using System.Reflection;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Diary.Application.Interfaces;
using Diary.Application.Services;

namespace Diary.Application;

public static class DependencyInjection
{

    /// <summary>
    /// Extensions: Add Diary Services
    /// </summary>
    /// <param name="services"></param>
    public static void AddDiaryApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetAssembly(typeof(Profile))); // all where inherit 'Profile' class 
        services.AddScoped<INoteEntityService, NoteEntityService>();
    }

}
