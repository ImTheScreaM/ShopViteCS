var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();
if (app.Environment.IsDevelopment()) app.MapOpenApi();

string Img(int id) => $"https://picsum.photos/seed/shop{id}/600/600";

var products = new List<Product>
{
    new(1,  "Футболки",       "Nike",           "Dri-FIT Classic",      2990m, Img(1)),
    new(2,  "Футболки",       "Adidas",         "Essentials Logo",      2490m, Img(2)),
    new(3,  "Футболки",       "Puma",           "Basic Tee",            1790m, Img(3)),
    new(4,  "Футболки",       "Uniqlo",         "Supima Cotton",        1990m, Img(4)),
    new(5,  "Джинсы",         "Levi's",         "501 Original",         7990m, Img(5)),
    new(6,  "Джинсы",         "Levi's",         "511 Slim",             6990m, Img(6)),
    new(7,  "Джинсы",         "Zara",           "Straight Fit",         4490m, Img(7)),
    new(8,  "Джинсы",         "H&M",            "Regular Fit",          2990m, Img(8)),
    new(9,  "Куртки",         "The North Face", "Resolve Rain",        12990m, Img(9)),
    new(10, "Куртки",         "Columbia",       "Watertight II",        9990m, Img(10)),
    new(11, "Куртки",         "Carhartt",       "Active Jacket",       14990m, Img(11)),
    new(12, "Куртки",         "Zara",           "Bomber Basic",         5990m, Img(12)),
    new(13, "Толстовки",      "Nike",           "Club Fleece Hoodie",   5490m, Img(13)),
    new(14, "Толстовки",      "Adidas",         "Trefoil Hoodie",       5990m, Img(14)),
    new(15, "Толстовки",      "Champion",       "Reverse Weave",        6490m, Img(15)),
    new(16, "Толстовки",      "Carhartt",       "Chase Sweatshirt",     7990m, Img(16)),
    new(17, "Кроссовки",      "Nike",           "Air Force 1 Low",     11990m, Img(17)),
    new(18, "Кроссовки",      "Adidas",         "Samba OG",            10990m, Img(18)),
    new(19, "Кроссовки",      "New Balance",    "574 Core",             9990m, Img(19)),
    new(20, "Кроссовки",      "Puma",           "Suede Classic",        7990m, Img(20)),
    new(21, "Кроссовки",      "Reebok",         "Classic Leather",      8490m, Img(21)),
    new(22, "Ботинки",        "Timberland",     "6-Inch Premium",      18990m, Img(22)),
    new(23, "Рюкзаки",        "Fjallraven",     "Kanken Classic",       9990m, Img(23)),
    new(24, "Рюкзаки",        "The North Face", "Borealis",             8990m, Img(24)),
    new(25, "Сумки",          "Puma",           "Shoulder Bag",         2990m, Img(25)),
    new(26, "Головные уборы", "New Era",        "9FORTY Classic",       2990m, Img(26)),
    new(27, "Головные уборы", "Carhartt",       "Watch Hat",            2490m, Img(27)),
    new(28, "Аксессуары",     "Levi's",         "Reversible Belt",      2990m, Img(28)),
    new(29, "Аксессуары",     "Casio",          "F-91W",                1990m, Img(29)),
    new(30, "Аксессуары",     "Ray-Ban",        "Wayfarer Classic",    12990m, Img(30)),
};

app.MapGet("/products", () => products);

app.MapGet("/products/{id:int}",(int id) => (
	products.FirstOrDefault(p => p.Id == id) is { } p 
	? Results.Ok() :
		Results.NotFound()
));

app.Run();

record Product(int Id, string Category, string Brand, string Name, decimal Price, string ImageUrl);
