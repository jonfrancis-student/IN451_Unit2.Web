using IN451_Unit2.Services;
using IN451_Unit2.Services.Interfaces;
using IN451_Unit2.DataAccess.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Retrieve the connection string from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//// Register dependencies for services and data access layers
//builder.Services.AddScoped<ICustomerService, CustomerService>(); // Register service layer and interface
//builder.Services.AddScoped<CustomerData>(provider => new CustomerData(connectionString)); // Register customer data access layer and pass in the connection string

// Registering CustomerService and passing connectionString
builder.Services.AddScoped<ICustomerService>(provider => new CustomerService(connectionString));
// Registering CustomerData and passing connectionString
builder.Services.AddScoped<CustomerData>(provider => new CustomerData(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
