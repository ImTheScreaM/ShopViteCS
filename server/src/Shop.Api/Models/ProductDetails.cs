namespace Shop.Api.Models;

public class ProductDetails {
	public int Id { get; set; }
 	public int ProductId { get; set; }

	public Product? Product { get; set; }
	public string? TypeDescription { get; set; } = ""; 
	public int? StockQuantity { get; set; } 
	public decimal? Weight { get; set; }
	public decimal? Height { get; set; }
	public decimal? Width { get; set; }
	public string? Article { get; set; }
}