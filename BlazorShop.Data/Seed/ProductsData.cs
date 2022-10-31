namespace BlazorShop.Data.Seed
{
    using System;
    using System.Collections.Generic;

    using Contracts;
    using Models;

    public class ProductsData : IInitialData
    {
        public Type EntityType => typeof(Product);

        public IEnumerable<object> GetData()
            => new List<Product>
            {
                new Product
                {
                    Name = "SILTEK F-22, Easy leveling screed",
                    Description = "For installing floor screeds, including on deformable surfaces with a height difference of 5 to 40 mm.",
                    ImageSource = "https://images.prom.ua/1294583164_siltek-f-22-styazhka.jpg",
                    Price = 6.77m,
                    Quantity = 40,
                    CategoryId = 1
                },
                new Product
                {
                    Name = "Polimin TP-5, self-leveling mixture",
                    Description = "Suitable for \"warm floor\" systems before the subsequent installation of linoleum, laminate, ceramic tiles, carpet and other coverings.",
                    ImageSource = "https://images.prom.ua/3127088105_polimin-tp-5-samovirivnyuyucha.jpg",
                    Price = 6.77m,
                    Quantity = 30,
                    CategoryId = 1
                },
                new Product
                {
                    Name = "Ceresit CF 56 Quartz Strengthening polymer",
                    Description = "Ceresit CF 56 QUARTZ is a ready-to-use dry mixture based on highly active cement, fractionated quartz filler, modifying additives, pigments.",
                    ImageSource = "https://images.prom.ua/2303647445_ceresit-cf-56.jpg",
                    Price = 13.50m,
                    Quantity = 10,
                    CategoryId = 1
                },
                new Product
                {
                    Name = "Metal stepladder WORK'S 7",
                    Description = "Metal ladder Works 407 7 steps Maximum load - 150 kg weight - 8 kg number of steps - 7",
                    ImageSource = "https://images.prom.ua/2676460864_stremyanka-metaleva-works.jpg",
                    Price = 33.99m,
                    Quantity = 5,
                    CategoryId = 2
                },
                new Product
                {
                    Name = "KNAUF plasterboard ceiling",
                    Description = "KNAUF ceiling plasterboard, 2.5 meters long, 9.5 mm thick",
                    ImageSource = "https://images.prom.ua/1272318649_stelovij-gipsokarton-knauf.jpg",
                    Price = 9.20m,
                    Quantity = 50,
                    CategoryId = 3
                },
                new Product
                {
                    Name = "KNAUF Gypsum board moisture resistant",
                    Description = "Drywall KNAUF moisture resistant, 9.5 mm thick, ceiling. Available at three warehouses in Kyiv. Delivery or pickup is possible, cash and non-cash payment.",
                    ImageSource = "https://images.prom.ua/1272318646_gipsokarton-vologostijkij-knauf.jpg",
                    Price = 9.99m,
                    Quantity = 60,
                    CategoryId = 3
                }
            };
    }
}

