//sets the app upp, merges configurations, and starts the web server
var builder = WebApplication.CreateBuilder(args);

//registers services for dependency injection ~ data access, UI rendering, etc.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//finalised the configuration and starts the app
var app = builder.Build();

//error handling and security settings
if (!app.Environment.IsDevelopment())// if not in development environment
{
    app.UseExceptionHandler("/Error");//redirects to error page on exceptions
    app.UseHsts();//enables HTTP Strict Transport Security for enhanced security
}

//middleware pipeline configuration -defines how HTTP requests are handled
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();
