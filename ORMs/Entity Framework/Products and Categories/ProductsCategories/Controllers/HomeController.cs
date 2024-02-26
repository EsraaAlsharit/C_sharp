using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// Add this using statement to be able to use PasswordHasher
using Microsoft.AspNetCore.Identity;
//for checking the seestion 
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;
using System.Web;

using ProductsCategories.Models;

namespace ProductsCategories.Controllers;

public class HomeController : Controller
{
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        List<Product> AllProducts = _context.Products.ToList();
        ViewBag.AllProducts = AllProducts;

        return View();
    }
    [HttpGet("Product/{id}")]
    public IActionResult Product(int id)
    {
        Product? Product = _context.Products
        .Include(Ass => Ass.Associations)
        .ThenInclude(Ass => Ass.Category)
        .FirstOrDefault(i => i.ProductId == id);

        ViewBag.Product = Product;

        List<Category> AllCategories = _context.Categories.ToList();
        ViewBag.AllCategories = AllCategories;
        return View();
    }
    [HttpGet("Category/{id}")]
    public IActionResult Category(int id)
    {
        Category? Category = _context.Categories
        .Include(Ass => Ass.Associations)
        .ThenInclude(Ass => Ass.Product)
        .FirstOrDefault(i => i.CategoryId == id);

        ViewBag.Category = Category;

        // List<Associations> AllAssociations = _context.Associations
        // .Where(c => c.CategoryId == id)
        // .ToList();

        List<Product> AllProducts = _context.Products
        // .Include(Ass => Ass.Associations)
        // .ThenInclude(Ass => Ass.Category.CategoryId !=id)
        // .Where(c => !c.Associations.Contains(id))
        .ToList();

        // List<Product> Products = new List<Product>();
        // foreach (var item in AllProducts)
        // {
        //     if (item.Associations.Count != 0)
        //         Products.Add(item);

        //     foreach (var itemtwo in item.Associations)
        //     {
        //         Console.WriteLine(itemtwo.CategoryId);
        //         Console.WriteLine(AllAssociations.Contains(itemtwo));
        //         if (!AllAssociations.Contains(itemtwo))
        //             // {
        //             Products.Add(item);
        //         // }
        //     }
        //     Console.WriteLine();

        // }
        // foreach (var item in AllProducts)
        // {
        // Console.WriteLine(item.Associations.Contains(id));

        //     if (!item.Associations.Find(x => (x.CategoryId != id)))
        //         Products.Add(item);
        // }

        // ViewBag.AllProducts = Products;
        ViewBag.AllProducts = AllProducts;
        return View();
    }

    public IActionResult Categories()
    {
        List<Category> AllCategories = _context.Categories.ToList();
        ViewBag.AllCategories = AllCategories;
        return View();
    }
    public IActionResult CreateProduct(Product newProduct)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newProduct);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            List<Product> AllProducts = _context.Products.ToList();
            ViewBag.AllProducts = AllProducts;
            return View("Index");
        }
    }
    public IActionResult CreateCategory(Category newCategory)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newCategory);
            _context.SaveChanges();
            return RedirectToAction("Categories");
        }
        else
        {
            List<Category> AllCategories = _context.Categories.ToList();
            ViewBag.AllCategories = AllCategories;
            return View("Index");
        }
    }

    public IActionResult AddProduct(int id, Associations newAssociation)
    {
        //         Category? Category = _context.Categories
        // .Include(Ass => Ass.Associations)
        // .ThenInclude(Ass => Ass.Product)
        // .FirstOrDefault(i => i.CategoryId == id);

        //         ViewBag.Category = Category;

        //         List<Product> AllProducts = _context.Products.ToList();
        //         ViewBag.AllProducts = AllProducts;
        //         if (ModelState.IsValid)
        //         {
        _context.Add(newAssociation);

        _context.SaveChanges();

        return RedirectToAction("Category", new { id = newAssociation.CategoryId });
        // }
        // else
        // {
        //     return View("Category", newAssociation);
        // }

    }
    public IActionResult AddCategory(int id, Associations newAssociation)
    {
        //         Category? Category = _context.Categories
        // .Include(Ass => Ass.Associations)
        // .ThenInclude(Ass => Ass.Product)
        // .FirstOrDefault(i => i.CategoryId == id);

        //         ViewBag.Category = Category;

        //         List<Product> AllProducts = _context.Products.ToList();
        //         ViewBag.AllProducts = AllProducts;

        // if (ModelState.IsValid)
        // {
        _context.Add(newAssociation);

        _context.SaveChanges();

        return RedirectToAction("Product", new { id = newAssociation.ProductId });

        // }
        // else
        // {
        // return View("Product", newAssociation);
        // }

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
