using Microsoft.AspNetCore.Mvc.Formatters;
using Newtonsoft.Json;
using System.Buffers;
using Tasks.Auth;
using Tasks.EF_Core;
using Tasks.EF_Core.Context;
using Tasks.Infrastructure;
using Tasks.Notifications;
using Tasks.Notifications.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddEF_Core(builder.Configuration);
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddAuth(builder.Configuration);
builder.Services.AddTelegramBot(builder.Configuration);
builder.Services.AddNotifications(builder.Configuration);

var policyName = "defaultAngularCorsPolicy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(policyName, builder =>
    {
        builder.WithOrigins("http://localhost:4200")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials();
    });
});

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policyName);

app.MapControllers();
app.UseStaticFiles();
app.UseRouting();

app.MapFallbackToFile("index.html");

using (var scope = app.Services.CreateScope())
{
    using (var db = scope.ServiceProvider.GetRequiredService<TasksContext>())
    {
        await db.Database.EnsureCreatedAsync();
    }
}

app.MapHub<NotifyUsersHub>("/notificationsHub");

app.Run();