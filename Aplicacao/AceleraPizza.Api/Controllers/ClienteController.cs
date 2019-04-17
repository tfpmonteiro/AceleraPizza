using AceleraPizza.Dominio.Interface.Service;
using AceleraPizza.Dominio.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace AceleraPizza.Api.Controllers
{
    [RoutePrefix("cliente")]
    public class ClienteController : ApiController
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        [Route("getall")]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _clienteService.BuscarTodos());
        }

        [HttpPost]
        [Route("")]
        public HttpResponseMessage Inserir([FromBody] ClienteInserirViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido");

            var clienteDtoReturn = _clienteService.Inserir(viewModel);

            if(clienteDtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, clienteDtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, clienteDtoReturn.Cliente);
        }
    }
}