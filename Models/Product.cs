using System;

namespace TechcareerDotnetBootcamp.Models
{
	public class Product
	{
		public int Id { get; private set; }
		public string Name { get; private set; }
		public decimal UnitPrice { get; private set; }
		public Category Category { get; private set; }

        public Product(int id, string name, decimal unitPrice, Category category)
		{
			Id = id;
			Name = name;
			UnitPrice = unitPrice;
			Category = category;
		}
	}
}

