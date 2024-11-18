using Microsoft.EntityFrameworkCore;
using PizzaStore.Models;
using Microsoft.EntityFrameworkCore.Sqlite;
public class PizzaDB : DbContext {
    public PizzaDB(DbContextOptions options) : base(options) {}
    public DbSet<Pizza> Pizzas { get; set; } = null!;
}