var builder = WebApplication.CreateBuilder(args);

// Add services to the container. Dependencies injection
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline. or middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=Index}/{id?}");

app.Run();
// equal to void main