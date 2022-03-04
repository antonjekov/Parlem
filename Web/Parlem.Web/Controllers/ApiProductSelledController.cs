using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parlem.Services.Data;
using Parlem.Web.ViewModels;
using Parlem.Web.ViewModels.ProductSelled;
using System.Linq;

namespace Parlem.Web.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ApiProductSelledController : ControllerBase
    {
        private IProductsSelledService productsSelledService;

        public ApiProductSelledController(IProductsSelledService productsSelledService)
        {
            this.productsSelledService = productsSelledService;
        }

        // Route https://localhost:44319/api/products?docNum=11223344E
        [HttpGet]
        public IActionResult Get(string docNum)
        {
            var products = this.productsSelledService.GetByDocNum<ProductSelledViewModel>(docNum);
            if (products.ToList().Count == 0)
            {
                return this.StatusCode(StatusCodes.Status204NoContent, new Response { Status = "Error", Message = "There is no products for this document Number." });
            }

            return this.Ok(products);
        }
    }
}
