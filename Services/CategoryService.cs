using TechcareerDotnetBootcamp.Models;

namespace TechcareerDotnetBootcamp.Services
{
	public class CategoryService
	{
		private static List<Category>? categories;

		public static List<Category> GetCategories()
		{
			if (categories == null)
			{
				categories = new List<Category>
				{
					new Category(1, "Menswear"),
					new Category(2, "Electronics"),
					new Category(3, "Art")
				};
			}

			return categories;
		}
	}
}

