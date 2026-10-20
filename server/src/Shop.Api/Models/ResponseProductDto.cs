namespace Shop.Api.Models;

public record ResponseProductDto (
	int Id,
	string Category,
	string Brand,
	string Name,
	string Price,
	string ImageUrl,
	string FullInformation,
	List<ResponseProductOptions> Options,
	ResponseProductDetails? Details
);

public record ResponseProductDetails(
	int Id,
	string TypeDescription,
	int? StockQuantity,
	decimal? Width,
	decimal? Height,
	decimal? Weight,
	string? Article 
);

public record ResponseProductOptions(
	int Id,
	string Name,
	string Value,
	int? StockQuantity
);