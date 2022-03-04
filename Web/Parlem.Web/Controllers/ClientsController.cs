using Microsoft.AspNetCore.Mvc;
using Parlem.Services.Data;
using Parlem.Web.ViewModels.Clients;
using Parlem.Web.ViewModels.Shared;

namespace Parlem.Web.Controllers
{
    public class ClientsController : BaseController
    {
        private IClientsService clientsService;

        public ClientsController(IClientsService clientsService)
        {
            this.clientsService = clientsService;
        }

        [HttpPost]
        public IActionResult Details(DocNumInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                this.RedirectToRoute(new { area = string.Empty, controller = "Home", action = "Index" });
            }

            var client = this.clientsService.GetByDocNum<ClientViewModel>(input.DocNum);

            return this.View(client);
        }

        public IActionResult Index()
        {
            return this.View();
        }
    }
}
