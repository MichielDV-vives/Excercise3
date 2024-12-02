using System.Diagnostics;
using Excercise3.Core;
using Microsoft.AspNetCore.Mvc;
using Excercise3.Models;

namespace Excercise3.Controllers;

public class HomeController : Controller
{
    private readonly ExcerciseDbContext _excerciseDbContext;
    private static ShoppingCart _shoppingCart = new ShoppingCart();

    public HomeController(ExcerciseDbContext excerciseDbContext)
    {
        _excerciseDbContext = excerciseDbContext;
    }

    public IActionResult Index()
    {
        var products = _excerciseDbContext.Products.ToList();
        ViewBag.Cart = _shoppingCart;
        return View(products);
    }


    
    public IActionResult ProductDetails(int id)
    {
        var product = _excerciseDbContext.Products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound();
        }
        return View(product);
    }
    
    [HttpPost]
    public IActionResult AddToCart(int id)
    {
        var product = _excerciseDbContext.Products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            _shoppingCart.Products.Add(product);
        }
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult RemoveFromCart(int id)
    {
        var product = _shoppingCart.Products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            _shoppingCart.Products.Remove(product);
        }
        return RedirectToAction("Index");
    }
    
    public IActionResult Checkout()
    {
        return View(_shoppingCart);
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