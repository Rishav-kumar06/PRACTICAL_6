using System.Collections.Generic;
using System.Web.Mvc;
using PRACTICAL_6.Models;

namespace PRACTICAL_6.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    Category = "Electronics",
                    Price = 55000,
                    Description = "High performance laptop",
                    ImageUrl = "https://png.pngtree.com/png-vector/20250522/ourmid/pngtree-modern-laptop-computer-with-screen-open-technology-digital-device-png-image_16345445.png"
                },

                new Product
                {
                    ProductId = 2,
                    ProductName = "Mobile Phone",
                    Category = "Electronics",
                    Price = 25000,
                    Description = "Android smartphone",
                    ImageUrl = "https://img.magnific.com/free-photo/smartphone-nature-concept_23-2150246099.jpg?semt=ais_hybrid&w=740&q=80"
                },

                new Product
                {
                    ProductId = 3,
                    ProductName = "Headphones",
                    Category = "Accessories",
                    Price = 2000,
                    Description = "Wireless headphones",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRQQGUTR_iUadxy4YCx0z2R6Rlbzv7jWAhbXSEzAEEuig&s"
                }
            };

            return View(products);
        }

        public ActionResult Details(int id)
        {
            Product product;

            if (id == 1)
            {
                product = new Product();

                product.ProductId = 1;
                product.ProductName = "Laptop";
                product.Category = "Electronics";
                product.Price = 55000;
                product.Description = "High performance laptop";
                product.ImageUrl = "https://png.pngtree.com/png-vector/20250522/ourmid/pngtree-modern-laptop-computer-with-screen-open-technology-digital-device-png-image_16345445.png";
            }
            else if (id == 2)
            {
                product = new Product();

                product.ProductId = 2;
                product.ProductName = "Mobile Phone";
                product.Category = "Electronics";
                product.Price = 25000;
                product.Description = "Android smartphone";
                product.ImageUrl = "https://img.magnific.com/free-photo/smartphone-nature-concept_23-2150246099.jpg?semt=ais_hybrid&w=740&q=80";
            }
            else
            {
                product = new Product();

                product.ProductId = 3;
                product.ProductName = "Headphones";
                product.Category = "Accessories";
                product.Price = 2000;
                product.Description = "Wireless headphones";
                product.ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRQQGUTR_iUadxy4YCx0z2R6Rlbzv7jWAhbXSEzAEEuig&s";
            }

            return View(product);
        }
    }
}