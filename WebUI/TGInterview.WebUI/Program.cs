using TGInterview.ApiRequestService.Abstract;
using TGInterview.ApiRequestService.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton<IApiRequestService, ApiRequestService>();
builder.Services.AddHttpClient("ProductServiceApi", options =>
{
    options.BaseAddress = new Uri(builder.Configuration.GetValue<string>("ProductServiceApiUrl"));
});

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

app.MapRazorPages();

app.Run();
