using Microsoft.AspNetCore.Mvc;
using Parlem.Services.Data;
using Parlem.Web.ViewModels.Clients;

namespace Parlem.Web.Controllers
{
    public class ClientsController : BaseController
    {
        private IClientsService clientsService;

        public ClientsController(IClientsService clientsService)
        {
            this.clientsService = clientsService;
        }

        public IActionResult Details(string id)
        {
            var client = this.clientsService.GetByDocNum<ClientViewModel>(id);

            return this.View(client);
        }

        public IActionResult Index()
        {
            return this.View();
        }

        [Route("api/clients/id")]
        public IActionResult DetailsApi(string id)
        {
            var client = this.clientsService.GetByDocNum<ClientViewModel>(id);

            return this.Json(client);
        }
    }
}
