namespace MVCDAY2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddSession(options =>
                options.IdleTimeout = TimeSpan.FromDays(2));
            var app = builder.Build();
            app.UseSession();

            // app.MapGet("/", () => "Hello World!");
            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}