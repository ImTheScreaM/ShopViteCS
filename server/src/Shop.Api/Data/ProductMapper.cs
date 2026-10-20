using Shop.Api.Models;

namespace Shop.Api.Data;

public static class ProductMapper {
	public static Product ToEntity(CreateProductDto dto) => new()
	{
		Category = dto.Category,
		Brand = dto.Brand,
		Name = dto.Name,
		Price = dto.Price,
		ImageUrl = dto.ImageUrl,
		FullInformation = dto.FullInformation,


		Options = [..dto.Options?.Select(o => new ProductOption
		{
			Name = o.Name,
			Value = o.Value,
			StockQuantity = o.StockQuantity,
			Article = o.Article

		}) ?? []],

		Details = dto.Details is null ? null : new ProductDetails
		{
			TypeDescription = dto.Details.TypeDescription,
			StockQuantity = dto.Details.StockQuantity,
			Width = dto.Details.Width,
			Weight = dto.Details.Weight,
			Height = dto.Details.Height
		}
	};

	public static ResponseProductDto ResponseDto(Product p) => new(
		p.Id,
		p.Category,
		p.Brand,
		p.Name,
		p.Price,
		p.ImageUrl,
		p.FullInformation,

		[..p.Options.Select(o => new ResponseProductOptions(
			o.Id,
			o.Name,
			o.Value,
			o.StockQuantity
		))],

	p.Details is null ? null : new ResponseProductDetails(
			p.Details.Id,
			p.Details.TypeDescription ?? "",
			p.Details.StockQuantity ?? 0,
			p.Details.Width,
			p.Details.Height,
			p.Details.Weight,
			p.Details.Article
		)
	);
}
