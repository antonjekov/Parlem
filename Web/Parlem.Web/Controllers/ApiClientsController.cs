namespace Parlem.Web.Controllers
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Parlem.Services.Data;
    using Parlem.Web.ViewModels;
    using Parlem.Web.ViewModels.Clients;

    [Route("api/clients")]
    [ApiController]
    public class ApiClientsController : ControllerBase
    {
        private IClientsService clientsService;

        public ApiClientsController(IClientsService clientsService)
        {
            this.clientsService = clientsService;
        }

        // Route https://localhost:44319/api/clients?docNum=11223344E
        [HttpGet]
        public IActionResult Get(string docNum)
        {
            var client = this.clientsService.GetByDocNum<ClientViewModel>(docNum);
            if (client == null)
            {
                return this.StatusCode(StatusCodes.Status204NoContent, new Response { Status = "Error", Message = "User with this document doesn't exist." });
            }

            return this.Ok(client);
        }
    }
}
