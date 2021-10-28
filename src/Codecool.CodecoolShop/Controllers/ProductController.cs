using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Codecool.CodecoolShop.Daos;
using Codecool.CodecoolShop.Daos.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Codecool.CodecoolShop.Models;
using Codecool.CodecoolShop.Services;

namespace Codecool.CodecoolShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        public ProductService ProductService { get; set; }

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
            ProductService = new ProductService(
                ProductDaoMemory.GetInstance(),
                ProductCategoryDaoMemory.GetInstance());
        }

        [HttpPost]
        public IActionResult Index() {
        }

        public IActionResult Index(int Category = 0)
        {
            
            ViewModel mymodel = new ViewModel();
            if (Category == 0)
            {
                mymodel.ProductCategories = ProductService.GetAllCategories();
                mymodel.Products = ProductService.GetAllProducts();
            }
            else
            {
                mymodel.ProductCategories = ProductService.GetAllCategories();
                mymodel.Products = ProductService.GetProductsForCategory(Category);
            }
            //mymodel.ProductCategories = ProductService.GetAllCategories();
            //mymodel.Products = ProductService.GetProductsForCategory(Category);
            //var products = ProductService.GetProductsForCategory(Category);
            //var products = ProductService.GetAllProducts();
            //return View(products.ToList());
            return View(mymodel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
