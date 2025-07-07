using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var products = new[]
        {
            new { id = 1, name = "Coffee", price = 3.50 },
            new { id = 2, name = "Tea",    price = 2.75 },
        };
        return Ok(products);
    }
}
