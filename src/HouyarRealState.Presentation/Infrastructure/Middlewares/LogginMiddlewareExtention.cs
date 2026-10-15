namespace HouyarRealState.Infrastructure.Middlewares
{
    public static class LogginMiddlewareExtention
    {
        public static void UseLoggin(this WebApplication app)
        {
            app.Use(async (context, next) =>
            {
                using var scope = app.Services.CreateScope();
                var logger = scope.ServiceProvider.GetService<ILogger<Program>>();
                try
                {
                    await next(context);
                }
                finally
                {

                    var statusCode = context.Response.StatusCode;

                    if (statusCode == StatusCodes.Status400BadRequest || statusCode == StatusCodes.Status404NotFound || statusCode == StatusCodes.Status500InternalServerError || statusCode == StatusCodes.Status401Unauthorized || statusCode == StatusCodes.Status403Forbidden || statusCode == StatusCodes.Status409Conflict)
                    {
                        logger?.LogError($"{context.Request.Method} {context.Request.Path} => {statusCode}{Environment.NewLine}");
                    }
                    else
                    {
                        logger?.LogInformation($"{context.Request.Method} {context.Request.Path} => {context.Response.StatusCode}{Environment.NewLine}");
                    }
                }
            });
        }
    }
}
