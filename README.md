# Depedency-Injection-in-Blazor

If you using Blazor WebAssembly App, change Lifetime Management in program.cs like this

  public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddTransient<ICustomerService, CustomerService>();
            await builder.Build().RunAsync();
        }
    }
