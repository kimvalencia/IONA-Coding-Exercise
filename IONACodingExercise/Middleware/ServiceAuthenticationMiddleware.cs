namespace IONACodingExercise.Middleware
{
    public class ServiceAuthenticationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string HEADER_API_KEY="API_KEY";
        public ServiceAuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if(!context.Request.Headers.TryGetValue(HEADER_API_KEY, out var extractedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Unauthorized Access");
                return;
            }

            var appSettings = context.RequestServices.GetRequiredService<IConfiguration>();
            var apiKey = appSettings.GetValue<string>(HEADER_API_KEY);
            if (!apiKey.Equals(extractedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Unauthorized Access");
                return;
            }

            await _next(context);
        }
    }
}
