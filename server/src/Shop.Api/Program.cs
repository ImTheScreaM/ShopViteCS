using Microsoft.EntityFrameworkCore;
using Shop.Api.Data;
using Shop.Api.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

builder.Services.AddDbContext<ShopDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();
if (app.Environment.IsDevelopment()) app.MapOpenApi();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ShopDbContext>();
    await db.Database.MigrateAsync();   

    if (!await db.Products.AnyAsync())
    {
        db.Products.AddRange(ProductSeeder.CreateProducts());
        await db.SaveChangesAsync();
    }
}

app.MapGet("/products", async (ShopDbContext db) =>
{
	var products = await db.Products
		.Include(p => p.Options)
		.Include(p => p.Details)
		.AsNoTracking()
		.ToListAsync();
	return products is null ? Results.NoContent() : Results.Ok(products.Select(ProductMapper.ResponseDto));
});

app.MapGet("/products/{id:int}", async (int id, ShopDbContext db) =>
{
	var product = await db.Products
		.Include(p => p.Options)
		.Include(p => p.Details)
		.AsNoTracking()
		.FirstOrDefaultAsync(p => p.Id == id);

	return product is null ? Results.NotFound() : Results.Ok(ProductMapper.ResponseDto(product));
});

app.MapPost("/product/create", async (CreateProductDto dto, ShopDbContext db) =>
{
	var product = ProductMapper.ToEntity(dto);
	db.Products.Add(product);
	await db.SaveChangesAsync();

	return Results.Created($"/product/create/{product.Id}", ProductMapper.ResponseDto(product));
});

app.MapDelete("/product/delete/{id:int}", async (int id, ShopDbContext db) =>
{
	var product = await db.Products.FindAsync(id);
	if (product is null) return Results.NotFound();

	db.Products.Remove(product);
	await db.SaveChangesAsync();

	return Results.NoContent();
});

app.Run();
