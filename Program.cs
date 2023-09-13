using BlazorApp8;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddServerComponents();
builder.Services.AddSyncfusionBlazor();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHNqVVhlXFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF9iSH9Vdk1mX31YdHBTQg==;Mgo+DSMBPh8sVXJ0S0V+XE9BdlRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS3xSd0RlWXdbdnZTQmZVVA==;ORg4AjUWIQA/Gnt2VVhjQlFac19JXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxRd0RiX39WdXJXQGRUU0E=;NzYyMDIxQDMyMzAyZTMzMmUzMGN5VVE4SnA0ZHlLUmZUWkcyWklHMDZ5QjNLQ0Nsb1FXVktLMWhFejdrR1E9;NzYyMDIyQDMyMzAyZTMzMmUzMGxiUGhsQ2M3dm4xTHJiUkxOdnoyczdEK0N4WUhpeHd6b1VxZzNDMzZIeWc9;NRAiBiAaIQQuGjN/V0Z+X09EaFpCVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdERiWHleeHFTRGZZV0Bz;NzYyMDI0QDMyMzAyZTMzMmUzMGVNTHJsMWFDSWNmbVFzbEkrK0d5bEk4WE9hQy9aTGpWSmVpWmVYUkdyVXc9;NzYyMDI1QDMyMzAyZTMzMmUzMFBUZ2QrdEdJY3g0bmtPMXdqRGVhNkdmSk5yZXg5RjcwYkVJK2EraTRjTUk9;Mgo+DSMBMAY9C3t2VVhjQlFac19JXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxRd0RiX39WdXJXQGZYUEE=;NzYyMDI3QDMyMzAyZTMzMmUzMENlUThuaEFiaDUrT1FacVM3OXY0MjBoSnJNNWJmWVpla2xnczkxVGdIZkk9;NzYyMDI4QDMyMzAyZTMzMmUzMFlsaG1HcnlDK1JpRS9VOWdnbUhaRmJMSkk0ZG5CYlIrdHR6ODJsVWRyTHc9;NzYyMDI5QDMyMzAyZTMzMmUzMGVNTHJsMWFDSWNmbVFzbEkrK0d5bEk4WE9hQy9aTGpWSmVpWmVYUkdyVXc9");
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

app.MapRazorComponents<App>();

app.Run();
