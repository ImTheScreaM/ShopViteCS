namespace Shop.Api.Models;

public class ProductOption {
	public int Id { get; set; }
	public int ProductId { get; set; }
 
	public Product? Product { get; set; }

	public string Name { get; set; } = "";
	public string Value { get; set; } = "";

	public int? StockQuantity { get; set; }

	public string? Article { get; set; }
}