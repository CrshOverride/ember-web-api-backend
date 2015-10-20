namespace EmberWebApi.Backend
{
    using Microsoft.AspNet.Builder;
    using Nancy.Owin;
 
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Use((context, next) =>
                {
                    context.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
                    context.Response.Headers.Add("Access-Control-Allow-Headers", new[] { "*" });
                    context.Response.Headers.Add("Access-Control-Allow-Methods", new[] { "*" });
                    return next();
                });
            
            app.UseOwin(x => x.UseNancy());
        }
    }
}
