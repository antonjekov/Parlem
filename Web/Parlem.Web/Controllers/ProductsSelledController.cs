using Microsoft.AspNetCore.Mvc;
using Parlem.Services.Data;
using Parlem.Web.ViewModels.ProductSelled;
using Parlem.Web.ViewModels.Shared;

namespace Parlem.Web.Controllers
{
    public class ProductsSelledController : BaseController
    {
        private IProductsSelledService productsSelledService;

        public ProductsSelledController(IProductsSelledService productsSelledService)
        {
            this.productsSelledService = productsSelledService;
        }

        [HttpPost]
        public IActionResult AllForClient(DocNumInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                this.RedirectToRoute(new { area = string.Empty, controller = "Home", action = "Index" });
            }

            var client = this.productsSelledService.GetByDocNum<ProductSelledViewModel>(input.DocNum);

            return this.View(client);
        }
    }
}
