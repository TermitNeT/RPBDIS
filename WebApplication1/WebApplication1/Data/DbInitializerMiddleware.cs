using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.Data
{
    public class DbInitializerMiddleware
    {
        private readonly RequestDelegate _next;
        public DbInitializerMiddleware(RequestDelegate next)
        {
            _next = next;

        }
        public Task Invoke(HttpContext context, IServiceProvider serviceProvider, Construction_Context dbContext)
        {
            /* Добавляем ключ в сессию, чтобы знать, инициализировали ли мы базу данных.
             Если ключ имеется в сессии, то продолжаем двигаться по конвейеру запросов,
             а иначе выполняем инициализацию БД.
             */
            if (!(context.Session.Keys.Contains("starting")))
            {
                DbInitializer.Initialize(dbContext);
                context.Session.SetString("starting", "Yes");
            }

            // Call the next delegate/middleware in the pipeline
            return _next.Invoke(context);
        }
    }

    public static class DbInitializerExtensions
    {
        public static IApplicationBuilder UseDbInitializer(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<DbInitializerMiddleware>();
        }

    }
}
