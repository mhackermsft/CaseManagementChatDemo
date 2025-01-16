using CaseManagementChatDemo.Components;
using CaseManagementChatDemo.Utils;
using CaseManagementModels;

namespace CaseManagementChatDemo;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.AddServiceDefaults();
        builder.Services.Configure<AppSettings>(builder.Configuration);

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        //Add a generic HttpClient to the service collection that has a base URL of https://casemanagementapi
        builder.Services.AddHttpClient("casemanagementapi", client =>
        {
            client.BaseAddress = new Uri("https://casemanagementapi");
        });

        builder.Services.AddHttpClient("retryHttpClient").AddPolicyHandler(RetryHelper.GetRetryPolicy());
  
        var app = builder.Build();
        app.MapDefaultEndpoints();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseAntiforgery();
        app.MapStaticAssets();
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        if (!Directory.Exists("knn"))
        {
            Directory.CreateDirectory("knn");
        }

        app.Run();
    }
}
