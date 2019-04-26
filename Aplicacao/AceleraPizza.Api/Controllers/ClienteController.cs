using AceleraPizza.Dominio.Interface.Service;
using AceleraPizza.Dominio.View;
using System;
using System.Net;
using System.Net.Http;
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

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(Guid id)
        {
            if(id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido");

            var clienteDtoReturn = _clienteService.BuscarPorId(id);

            return Request.CreateResponse(HttpStatusCode.OK, clienteDtoReturn);
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

        [HttpPut]
        [Route("")]
        public HttpResponseMessage Editar([FromBody] ClienteAtualizarViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

            var clienteDtoReturn = _clienteService.Atualizar(viewModel);

            if(clienteDtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, clienteDtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, clienteDtoReturn.Cliente);
        }

        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage Delete(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

            _clienteService.Excluir(id);

            return Request.CreateResponse(HttpStatusCode.NoContent);
        }
    }
}