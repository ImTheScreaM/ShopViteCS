namespace Shop.Api.Models;

public class Product {
	public int Id { get; set; }
	public string Category { get; set; } = "";
	public string Brand { get; set; } = "";
	public string Name { get; set; } = "";
	public string Price { get; set; } = "";
	public string ImageUrl { get; set; } = "";
	public string FullInformation { get; set; } = "";

	public List<ProductOption> Options { get; set; } = new();
	public ProductDetails? Details { get; set; }
}