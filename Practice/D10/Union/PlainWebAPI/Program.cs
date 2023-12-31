var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "",
    pattern: "");
// app.MapControllerRoute(name: "productid",
//     pattern: "{controller=Product}/{action=GetById}/{id}");
// app.MapControllerRoute(name: "product",
//     pattern: "{controller=Product}/{action=GetByCompany}/{name}");
app.Run();