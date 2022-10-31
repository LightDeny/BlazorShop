namespace BlazorShop.Data.Seed
{
    using System;
    using System.Collections.Generic;

    using Contracts;
    using Models;

    public class CategoriesData : IInitialData
    {
        public Type EntityType => typeof(Category);

        public IEnumerable<object> GetData()
            => new List<Category>
            {
                new Category { Name = "BUILDING MIXTURES" },
                new Category { Name = "TOOLS" },
                new Category { Name = "GYPSUM CARTON SYSTEMS" }
            };
    }
}

