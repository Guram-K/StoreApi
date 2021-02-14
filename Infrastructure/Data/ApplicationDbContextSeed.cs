using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext dbContext, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!dbContext.ProductTypes.Any())
                {
                    var typesData = File.ReadAllText("../Infrastructure/Data/SeedData/types.json");
                    var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);

                    foreach (var item in types)
                    {
                         var tmp = new ProductType() { Name = item.Name };
                         dbContext.ProductTypes.Add(tmp);
                    }

                    await dbContext.SaveChangesAsync();
                }

                 if (!dbContext.ProductBrands.Any())
                 {
                     var brandsData = File.ReadAllText("../Infrastructure/Data/SeedData/brands.json");
                     var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

                     foreach (var item in brands)
                     {
                        var tmp = new ProductBrand() { Name = item.Name };
                        dbContext.ProductBrands.Add(tmp);
                     }

                     await dbContext.SaveChangesAsync();
                 }

                if (!dbContext.Products.Any())
                {
                    var productsData = File.ReadAllText("../Infrastructure/Data/SeedData/products.json");
                    var products = JsonSerializer.Deserialize<List<Product>>(productsData);

                    foreach (var item in products)
                    {
                        var tmp = new Product() { Name = item.Name, 
                                                  Description = item.Description, 
                                                  Price = item.Price, 
                                                  PictureUrl = item.PictureUrl, 
                                                  ProductTypeId = item.ProductTypeId, 
                                                  ProductBrandId = item.ProductBrandId};
                        dbContext.Products.Add(tmp);
                    }

                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<ApplicationDbContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}
