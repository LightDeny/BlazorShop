namespace BlazorShop.Tests.Services
{
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Shouldly;
    using Xunit;

    using BlazorShop.Services.Products;
    using Common;
    using Data;
    using Models.Products;

    public class ProductsServiceTests : SetupFixture
    {
        private readonly IProductsService products;

        public ProductsServiceTests()
            => this.products = new ProductsService(this.Data, this.Mapper);

        [Theory]
        [InlineData("Product 1", "Description 1", "Image 1", 3, 3.50, 1)]
        [InlineData("Product 2", "Description 2", "Image 2", 6, 6.50, 2)]
        [InlineData("Product 3", "Description 3", "Image 3", 9, 9.99, 3)]
        public async Task CreateShouldWorkCorrectly(
            string name,
            string description,
            string imageSource,
            int quantity,
            decimal price,
            int categoryId)
        {
            var request = new ProductsRequestModel
            {
                Name = name,
                Description = description,
                ImageSource = imageSource,
                Quantity = quantity,
                Price = price,
                CategoryId = categoryId
            };

            var id = await this.products.CreateAsync(request);

            var product = await this.Data.Products.FindAsync(id);

            product.Id.ShouldBe(id);
            product.Name.ShouldBe(request.Name);
            product.Description.ShouldBe(request.Description);
            product.ImageSource.ShouldBe(request.ImageSource);
            product.Quantity.ShouldBe(request.Quantity);
            product.Price.ShouldBe(request.Price);
            product.CategoryId.ShouldBe(request.CategoryId);
        }

        [Theory]
        [InlineData(1, "Updated 1", "Updated description 1", "Updated image 1", 3, 3.50, 1)]
        [InlineData(2, "Updated 2", "Updated description 2", "Updated image 2", 6, 6.50, 2)]
        [InlineData(3, "Updated 3", "Updated description 3", "Updated image 3", 9, 9.99, 3)]
        public async Task UpdateShouldWorkCorrectly(
            int count,
            string name,
            string description,
            string imageSource,
            int quantity,
            decimal price,
            int categoryId)
        {
            const int id = 1;

            await this.AddFakeProducts(count);

            var request = new ProductsRequestModel
            {
                Name = name,
                Description = description,
                ImageSource = imageSource,
                Quantity = quantity,
                Price = price,
                CategoryId = categoryId
            };

            var result = await this.products.UpdateAsync(id, request);

            var product = await this.Data.Products.FindAsync(id);

            result.Succeeded.ShouldBeTrue();

            product.Id.ShouldBe(id);
            product.Name.ShouldBe(request.Name);
            product.Description.ShouldBe(request.Description);
            product.ImageSource.ShouldBe(request.ImageSource);
            product.Quantity.ShouldBe(request.Quantity);
            product.Price.ShouldBe(request.Price);
            product.CategoryId.ShouldBe(request.CategoryId);
        }

        private async Task AddFakeProducts(int count)
        {
            var fakes = ProductsTestData.GetProducts(count);

            await this.Data.AddRangeAsync(fakes);
            await this.Data.SaveChangesAsync();
        }
    }
}
