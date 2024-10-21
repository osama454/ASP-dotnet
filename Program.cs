var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // Add support for MVC
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor(); // Add support for server-side Blazor components
builder.Services.AddSession();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers(); // Map MVC controllers
app.MapRazorPages();
app.MapBlazorHub(); // Map Blazor hub for server-side Blazor components
app.UseSession();

app.UseAuthentication();



app.Run();
