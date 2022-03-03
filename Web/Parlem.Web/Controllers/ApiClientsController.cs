using Microsoft.AspNetCore.Mvc;
using Parlem.Services.Data;
using Parlem.Web.ViewModels.Clients;
using System.Threading.Tasks;
using Parlem.Web.ViewModels.Clients;
using System.Collections.Generic;

namespace Parlem.Web.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ApiClientsController : ControllerBase
    {
        private IClientsService clientsService;

        public ApiClientsController(IClientsService clientsService)
        {
            this.clientsService = clientsService;
        }

        // Route api/clients?docNum = ????
        [HttpGet]
        public ClientViewModel Get(string docNum)
        {
            var client = this.clientsService.GetByDocNum<ClientViewModel>(docNum);
            return client;
        }
    }
}
