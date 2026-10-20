using Microsoft.EntityFrameworkCore;
using Shop.Api.Models;

namespace Shop.Api.Data;

public class ShopDbContext : DbContext
{
	public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) { }

	public DbSet<Product> Products => Set<Product>();
	public DbSet<ProductOption> Option => Set<ProductOption>();
	public DbSet<ProductDetails> Details => Set<ProductDetails>();

	protected override void OnModelCreating(ModelBuilder modeBuilder)
	{
		modeBuilder.Entity<Product>(e =>
		{
			e.ToTable("product");

			e.HasKey(p => p.Id);
			e.Property(p => p.Price).HasMaxLength(50);

			e.HasMany(p => p.Options)
				.WithOne(o => o.Product)
				.HasForeignKey(o => o.ProductId)
				.OnDelete(DeleteBehavior.Cascade);

			e.HasOne(p => p.Details)
				.WithOne(o => o.Product)
				.HasForeignKey<ProductDetails>(o => o.ProductId)
				.OnDelete(DeleteBehavior.Cascade);
		});

		modeBuilder.Entity<ProductOption>(e =>
		{
			e.ToTable("product_option");
			e.HasKey(p => p.Id);
			e.Property(p => p.Name).HasMaxLength(200).IsRequired();
			e.Property(p => p.Value).HasMaxLength(200).IsRequired();
			e.Property(p => p.Article).HasMaxLength(200);

			e.HasIndex(o => new { o.ProductId, o.Name });
			e.HasIndex(o => o.Name);
		});

		modeBuilder.Entity<ProductDetails>(e =>
		{
			e.ToTable("product_details");
			e.HasKey(p => p.Id);
			e.Property(p=> p.Weight).HasPrecision(10,2);
			e.Property(p=> p.Height).HasPrecision(10,2);
			e.Property(p => p.Width).HasPrecision(10, 2);
		});
	}
}