
using BoatLibrary.Interfaces;
using BoatLibrary.Repos;
using BoatLibrary.Objects;
public class Program
{
    public static bool LoggedIn = false;
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddSingleton<Member>(new Member());
        builder.Services.AddSingleton<IMemberRepository, MemberRepo>();
        builder.Services.AddSingleton<IBoatRepository, BoatRepo>();
        builder.Services.AddSingleton<IBookingRepository, BookkingRepository>();
        builder.Services.AddSingleton<IEventRepository, EventRepo>();
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();

        app.Run();
    }
}