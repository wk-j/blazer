using Microsoft.Fast.Components.FluentUI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Blazor app
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();
builder.Services.AddRazorPages();
builder.Services.AddFluentUIComponents();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Blazor app
app.UseStaticFiles();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
