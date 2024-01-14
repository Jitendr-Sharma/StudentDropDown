using Microsoft.EntityFrameworkCore;
using StudentDropDow.Data;
using Microsoft.AspNetCore.Identity;
using StudentDropDow.Areas.Identity.Data;



var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;



var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("DefaultConnection");

builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<StudentDropDowContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<StudentUserLogin>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<StudentDropDowContext>();


// Add services to the container.
builder.Services.AddControllersWithViews();


//.AddGoogle(options =>
//{
//    IConfigurationSection googleAuthNSection =
//    config.GetSection("");
//    options.ClientId = "";
//    options.ClientSecret = "";
//});
//.AddFacebook(options =>
//{
//    IConfigurationSection FBAuthNSection =
//    config.GetSection("Authentication:FB");
//    options.ClientId = FBAuthNSection[""];
//    options.ClientSecret = FBAuthNSection[""];
//})
//.AddMicrosoftAccount(microsoftOptions =>
//{
//    microsoftOptions.ClientId = config[""];
//    microsoftOptions.ClientSecret = config[""];
//})
//.AddTwitter(twitterOptions =>
//{
//    twitterOptions.ConsumerKey = config["Authentication:Twitter:ConsumerAPIKey"];
//    twitterOptions.ConsumerSecret = config["Authentication:Twitter:ConsumerSecret"];
//    twitterOptions.RetrieveUserDetails = true;
//});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}




app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employees}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
