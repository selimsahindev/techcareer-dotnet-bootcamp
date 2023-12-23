using TechcareerDotnetBootcamp.Models;

namespace TechcareerDotnetBootcamp.Services
{
	public class ProductService
	{
		private static List<Product>? products;

		public static List<Product> GetProducts()
		{
			List<Category> categories = CategoryService.GetCategories();

			if (products == null)
			{
				products = new List<Product>
				{
					new Product(1, "Leather Jacket", 200, categories[0]),
					new Product(2, "Macbook Pro", 3000, categories[1]),
                    new Product(3, "Piano", 11890, categories[2]),
					new Product(4, "Smart Watch", 480, categories[1])
				};
			}

			return products;
		}

		public static Product GetProductById(int id)
		{
			return products.FirstOrDefault(product => product.Id == id);
		}

		public static void Create(int id, string name, decimal unitPrice, Category category)
		{
			Product newProduct = new Product(id, name, unitPrice, category);
			products.Add(newProduct);
		}

		public static void Delete(int id)
		{
			Product product = products.FirstOrDefault(product => product.Id == id);

			if (product == null)
			{
				return;
			}

			products.Remove(product);
		}
	}
}

