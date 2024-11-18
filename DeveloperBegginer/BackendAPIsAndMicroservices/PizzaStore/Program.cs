using Microsoft.OpenApi.Models;
// using PizzaStore.DB;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Models;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => {});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "PizzaStore API", Description = "API for PizzaStore", Version = "v1" });
});
// InMemory Database
// builder.Services.AddDbContext<PizzaDB>(options => options.UseInMemoryDatabase("items"));

var connectionString = builder.Configuration.GetConnectionString("Pizzas") ?? "Data Source=Pizzas.db";
builder.Services.AddSqlite<PizzaDB>(connectionString);

var app = builder.Build();

if (app.Environment.IsDevelopment()) {

    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "PizzaStore API V1");
    });
}
app.MapGet("/", () => "Hello World!");

// GET request
app.MapGet("/pizzas", async (PizzaDB db) => await db.Pizzas.ToListAsync());

// GET request with id
app.MapGet("/pizzas/{id}", async(PizzaDB db, int id) => await db.Pizzas.FindAsync(id));

// POST request
app.MapPost(".pizzas", async (PizzaDB db, Pizza pizza) => {
    await db.Pizzas.AddAsync(pizza);
    await db.SaveChangesAsync();
    return Results.Created($"/pizza/{pizza.Id}", pizza);
});

// PUT request
app.MapPut("/pizzas", async (PizzaDB db, Pizza updatePizza, int id) => {
    var pizza = await db.Pizzas.FindAsync(id);
    if (pizza is null) return Results.NotFound();
    pizza.Name = updatePizza.Name;
    pizza.Description = updatePizza.Description;
    await db.SaveChangesAsync();
    return Results.NoContent();
});

// DELETE request
app.MapDelete("/pizzas/{id}", async (PizzaDB db, int id) => {
    var pizza = await db.Pizzas.FindAsync(id);
    if (pizza is null) return Results.NotFound();
    db.Pizzas.Remove(pizza);
    await db.SaveChangesAsync();
    return Results.NoContent();
});


// Allow all origins for minimal API
// app.UseCors("AllowAll");


// Minimal API
// app.MapGet("/pizzas", () => PizzaDB.GetPizzas());
// app.MapGet("/pizzas/{id}", (int id) => PizzaDB.GetPizza(id));
// app.MapPost("/pizzas", (Pizza pizza) => PizzaDB.CreatePizza(pizza));
// app.MapPut("/pizzas", (Pizza pizza) => PizzaDB.UpdatePizza(pizza));
// app.MapDelete("/pizzas/{id}", (int id) => PizzaDB.RemovePizza(id));

app.Run();
