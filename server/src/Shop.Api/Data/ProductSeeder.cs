// Эту хуйню просто сгенерировала ИИ

using Shop.Api.Models;

namespace Shop.Api.Data;

public static class ProductSeeder
{
    private static string Img(int id) => $"https://picsum.photos/seed/shop{id}/600/600";

    public static List<Product> CreateProducts()
    {
        return new List<Product>
        {
            Clothing(1,  "Футболки",       "Nike",           "Dri-FIT Classic",      2990m,  "Классическая футболка Nike Dri-FIT из влагоотводящей ткани. Свободный крой, логотип на груди.", new[] { "S", "M", "L", "XL", "XXL" }, new[] { 3, 5, 8, 2, 1 }, 200),
            Clothing(2,  "Футболки",       "Adidas",         "Essentials Logo",      2490m,  "Футболка Adidas Essentials с логотипом. Хлопок 100%, Regular Fit.", new[] { "S", "M", "L", "XL" }, new[] { 4, 6, 5, 2 }, 180),
            Clothing(3,  "Футболки",       "Puma",           "Basic Tee",            1790m,  "Базовая футболка Puma из мягкого хлопка. Универсальный вариант на каждый день.", new[] { "S", "M", "L", "XL" }, new[] { 5, 7, 6, 3 }, 170),
            Clothing(4,  "Футболки",       "Uniqlo",         "Supima Cotton",        1990m,  "Футболка Uniqlo из хлопка Supima — премиальное качество и мягкость.", new[] { "S", "M", "L", "XL", "XXL" }, new[] { 2, 4, 6, 3, 1 }, 190),
            Clothing(5,  "Джинсы",         "Levi's",         "501 Original",         7990m,  "Легендарные джинсы Levi's 501 Original. Прямой крой, пуговицы на ширинке.", new[] { "28", "30", "32", "34", "36" }, new[] { 2, 4, 5, 3, 1 }, 700),
            Clothing(6,  "Джинсы",         "Levi's",         "511 Slim",             6990m,  "Джинсы Levi's 511 Slim Fit — зауженный крой, комфортная посадка.", new[] { "28", "30", "32", "34", "36" }, new[] { 3, 5, 6, 2, 1 }, 680),
            Clothing(7,  "Джинсы",         "Zara",           "Straight Fit",         4490m,  "Прямые джинсы Zara из плотного денима. Универсальный цвет indigo.", new[] { "28", "30", "32", "34", "36" }, new[] { 4, 6, 5, 3, 1 }, 650),
            Clothing(8,  "Джинсы",         "H&M",            "Regular Fit",          2990m,  "Джинсы H&M Regular Fit. Доступный вариант на каждый день.", new[] { "28", "30", "32", "34", "36" }, new[] { 5, 7, 6, 3, 2 }, 640),
            Clothing(9,  "Куртки",         "The North Face", "Resolve Rain",        12990m,  "Дождевая куртка The North Face Resolve с мембраной DryVent.", new[] { "S", "M", "L", "XL" }, new[] { 2, 3, 3, 1 }, 400),
            Clothing(10, "Куртки",         "Columbia",       "Watertight II",        9990m,  "Куртка Columbia Watertight II — защита от дождя и ветра.", new[] { "S", "M", "L", "XL" }, new[] { 2, 4, 3, 2 }, 380),
            Clothing(11, "Куртки",         "Carhartt",       "Active Jacket",       14990m,  "Утеплённая куртка Carhartt Active с капюшоном. Деним, флисовая подкладка.", new[] { "S", "M", "L", "XL" }, new[] { 1, 2, 3, 2 }, 900),
            Clothing(12, "Куртки",         "Zara",           "Bomber Basic",         5990m,  "Бомбер Zara Basic — лёгкая куртка на каждый день.", new[] { "S", "M", "L", "XL" }, new[] { 3, 5, 4, 2 }, 500),
            Clothing(13, "Толстовки",      "Nike",           "Club Fleece Hoodie",   5490m,  "Худи Nike Club Fleece из мягкого флиса. Кенгуру-карман, регулируемый капюшон.", new[] { "S", "M", "L", "XL", "XXL" }, new[] { 3, 5, 7, 4, 2 }, 450),
            Clothing(14, "Толстовки",      "Adidas",         "Trefoil Hoodie",       5990m,  "Худи Adidas Trefoil с большим логотипом. Хлопок, Regular Fit.", new[] { "S", "M", "L", "XL" }, new[] { 3, 5, 6, 3 }, 470),
            Clothing(15, "Толстовки",      "Champion",       "Reverse Weave",        6490m,  "Худи Champion Reverse Weave — культовая модель из плотного хлопка.", new[] { "S", "M", "L", "XL" }, new[] { 2, 4, 5, 2 }, 520),
            Clothing(16, "Толстовки",      "Carhartt",       "Chase Sweatshirt",     7990m,  "Свитшот Carhartt Chase с вышитым логотипом. Плотный футер.", new[] { "S", "M", "L", "XL" }, new[] { 2, 3, 4, 2 }, 550),

            Shoes(17, "Кроссовки", "Nike",        "Air Force 1 Low",  11990m, "Классические кроссовки Nike Air Force 1 Low. Кожа, амортизация Air.", new[] { "40", "41", "42", "43", "44", "45" }, new[] { 2, 4, 5, 3, 2, 1 }, 450),
            Shoes(18, "Кроссовки", "Adidas",      "Samba OG",         10990m, "Кроссовки Adidas Samba OG — классика с замшевыми вставками.", new[] { "40", "41", "42", "43", "44", "45" }, new[] { 3, 4, 5, 4, 2, 1 }, 420),
            Shoes(19, "Кроссовки", "New Balance", "574 Core",          9990m, "Кроссовки New Balance 574 Core. Замша и сетка, амортизация ENCAP.", new[] { "40", "41", "42", "43", "44", "45" }, new[] { 2, 4, 5, 4, 3, 1 }, 400),
            Shoes(20, "Кроссовки", "Puma",        "Suede Classic",     7990m, "Кроссовки Puma Suede Classic — замшевые, с формованной подошвой.", new[] { "40", "41", "42", "43", "44", "45" }, new[] { 3, 5, 6, 4, 2, 1 }, 380),
            Shoes(21, "Кроссовки", "Reebok",      "Classic Leather",   8490m, "Кроссовки Reebok Classic Leather. Кожа, мягкая амортизация.", new[] { "40", "41", "42", "43", "44", "45" }, new[] { 2, 4, 5, 4, 2, 1 }, 390),
            Shoes(22, "Ботинки",   "Timberland",  "6-Inch Premium",   18990m, "Ботинки Timberland 6-Inch Premium. Водоотталкивающая кожа, утеплённые.", new[] { "40", "41", "42", "43", "44", "45" }, new[] { 1, 2, 3, 3, 2, 1 }, 1200),

            Bags(23, "Рюкзаки", "Fjallraven",     "Kanken Classic", 9990m, "Рюкзак Fjallraven Kanken Classic. Водоотталкивающий материал Vinylon F.", "20 л", 450),
            Bags(24, "Рюкзаки", "The North Face", "Borealis",       8990m, "Рюкзак The North Face Borealis. 28 л, отделение для ноутбука.", "28 л", 900),
            Bags(25, "Сумки",   "Puma",           "Shoulder Bag",   2990m, "Сумка Puma Shoulder Bag через плечо. Лёгкая, на молнии.", "5 л", 250),

            Accessory(26, "Головные уборы", "New Era",  "9FORTY Classic",    2990m,  "Бейсболка New Era 9FORTY Classic. Регулируемый ремешок.", "One Size", 120),
            Accessory(27, "Головные уборы", "Carhartt", "Watch Hat",         2490m,  "Шапка Carhartt Watch Hat. Акрил, плотная вязка.", "One Size", 100),
            Accessory(28, "Аксессуары",     "Levi's",   "Reversible Belt",   2990m,  "Ремень Levi's двусторонний. Кожа, пряжка из металла.", "M/L", 200),
            Accessory(29, "Аксессуары",     "Casio",    "F-91W",             1990m,  "Часы Casio F-91W. Классика, водозащита 30 м.", "One Size", 50),
            Accessory(30, "Аксессуары",     "Ray-Ban",  "Wayfarer Classic", 12990m,  "Очки Ray-Ban Wayfarer Classic. Солнцезащитные, UV400.", "One Size", 100),
        };
    }

    // Одежда: размеры + цвета
    private static Product Clothing(int id, string category, string brand, string name, decimal price,
        string info, string[] sizes, int[] stock, int weight)
    {
        var p = new Product
        {
            Id = id,
            Category = category,
            Brand = brand,
            Name = name,
            Price = price.ToString("0"),
            ImageUrl = Img(id),
            FullInformation = info,
        };

        for (int i = 0; i < sizes.Length; i++)
        {
            p.Options.Add(new ProductOption
            {
                Name = "Размер",
                Value = sizes[i],
                StockQuantity = stock[i],
            });
        }

        p.Options.Add(new ProductOption { Name = "Цвет", Value = "Чёрный", StockQuantity = stock.Sum() / 2 });
        p.Options.Add(new ProductOption { Name = "Цвет", Value = "Белый",  StockQuantity = stock.Sum() / 3 });

        p.Details = new ProductDetails
        {
            TypeDescription = "Одежда, унисекс",
            StockQuantity = stock.Sum(),
            Weight = weight,
        };

        return p;
    }

    // Обувь: размеры (числовые)
    private static Product Shoes(int id, string category, string brand, string name, decimal price,
        string info, string[] sizes, int[] stock, int weight)
    {
        var p = new Product
        {
            Id = id,
            Category = category,
            Brand = brand,
            Name = name,
            Price = price.ToString("0"),
            ImageUrl = Img(id),
            FullInformation = info,
        };

        for (int i = 0; i < sizes.Length; i++)
        {
            p.Options.Add(new ProductOption
            {
                Name = "Размер",
                Value = sizes[i],
                StockQuantity = stock[i],
            });
        }

        p.Details = new ProductDetails
        {
            TypeDescription = "Обувь, унисекс",
            StockQuantity = stock.Sum(),
            Weight = weight,
        };

        return p;
    }

    // Сумки/рюкзаки: объём
    private static Product Bags(int id, string category, string brand, string name, decimal price,
        string info, string volume, int weight)
    {
        var p = new Product
        {
            Id = id,
            Category = category,
            Brand = brand,
            Name = name,
            Price = price.ToString("0"),
            ImageUrl = Img(id),
            FullInformation = info,
        };

        p.Options.Add(new ProductOption { Name = "Объём", Value = volume, StockQuantity = 5 });

        p.Details = new ProductDetails
        {
            TypeDescription = "Сумка / рюкзак",
            StockQuantity = 5,
            Weight = weight,
        };

        return p;
    }

    // Аксессуары: размер один
    private static Product Accessory(int id, string category, string brand, string name, decimal price,
        string info, string size, int weight)
    {
        var p = new Product
        {
            Id = id,
            Category = category,
            Brand = brand,
            Name = name,
            Price = price.ToString("0"),
            ImageUrl = Img(id),
            FullInformation = info,
        };

        p.Options.Add(new ProductOption { Name = "Размер", Value = size, StockQuantity = 5 });

        p.Details = new ProductDetails
        {
            TypeDescription = "Аксессуар",
            StockQuantity = 5,
            Weight = weight,
        };

        return p;
    }
}