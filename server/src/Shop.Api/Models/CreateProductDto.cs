namespace Shop.Api.Models;

public record CreateProductDto (
	string Category,
	string Brand,
	string Name,
	string Price,
	string ImageUrl,
	string FullInformation,
	List<CreateProductOptions>? Options,
	CreateProductDetails? Details
);

public record CreateProductDetails(
	string TypeDescription,
	int StockQuantity,
	decimal? Width,
	decimal? Height,
	decimal? Weight,
	string Article
);

public record CreateProductOptions(
	string Name,
	string Value,
	int? StockQuantity,
	string Article
);