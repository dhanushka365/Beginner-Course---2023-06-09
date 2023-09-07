using System.Diagnostics;

namespace Beginner_Course___2023_06_09
{
    public class Middleware
    {
        public RequestDelegate request;
        private readonly string EnvironmentName;

        [Obsolete]
        public Middleware(RequestDelegate next, Microsoft.Extensions.Hosting.IHostingEnvironment env)
        {
            request = next;
            this.EnvironmentName = env.EnvironmentName;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Method == HttpMethods.Get && context.Request.Query["custom1"] == "true")
            {
                var timmer = Stopwatch.StartNew();
                await context.Response.WriteAsync("Custom Middleware2 \n");
                //await Next(context);

            }
            
        }

        private string DateTime(Stopwatch timmer)
        {
            throw new NotImplementedException();
        }

        //private Task Next(HttpContext context)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
