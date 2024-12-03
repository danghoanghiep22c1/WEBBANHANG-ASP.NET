﻿using Microsoft.EntityFrameworkCore;
using WEBBANHANG.Models;
using WEBBANHANG.Repository;

namespace Shopping_Tutorial.Repository
{
	public class SeedData
	{
		public static void SeedingData(DataContext _context)
		{
			_context.Database.Migrate();
			if (!_context.Products.Any())
			{
				CategoryModel macbook = new CategoryModel { Name = "Macbook", Slug = "macbook", Description = "Macbook is Lagre Product in the world", Status = 1 };
				CategoryModel pc = new CategoryModel { Name = "Pc", Slug = "pc", Description = "PC is Lagre Product in the world", Status = 1 };

				BrandModel apple = new BrandModel { Name = "Apple", Slug = "apple", Description = "Apple is Lagre Brand in the world", Status = 1 };
				BrandModel samsung = new BrandModel { Name = "Samsung", Slug = "samsung", Description = "Samsung is Lagre Brand in the world", Status = 1 };

				_context.Products.AddRange(

					new ProductModel { Name = "Macbook", Slug = "macbook", Description = "Macbook is best", Image = "1.jpg", Category = macbook, Brand = apple, Price = 1123 },
					new ProductModel { Name = "Pc", Slug = "pc", Description = "Pc is best", Image = "1.jpg", Category = pc, Brand = samsung, Price = 1123 }


				);
				_context.SaveChanges();
			}
		}
	}
}