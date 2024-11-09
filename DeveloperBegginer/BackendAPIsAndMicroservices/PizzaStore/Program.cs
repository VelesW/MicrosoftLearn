using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => {});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "PizzaStore API", Description = "API for PizzaStore", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment()) {

    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "PizzaStore API V1");
    });
}
app.MapGet("/", () => "Hello World!");

app.UseCors("AllowAll");

app.Run();
