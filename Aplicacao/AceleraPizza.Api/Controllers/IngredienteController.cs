using AceleraPizza.Dominio.Interface.Service;
using AceleraPizza.Dominio.View;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace AceleraPizza.Api.Controllers
{
    [RoutePrefix("ingrediente")]
    public class IngredienteController : ApiController
    {
        private readonly IIngredienteService _service;

        public IngredienteController(IIngredienteService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("getall")]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _service.BuscarTodos());
        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido");

            var ingredienteDtoReturn = _service.BuscarPorId(id);

            return Request.CreateResponse(HttpStatusCode.OK, ingredienteDtoReturn);
        }

        [HttpPost]
        [Route("")]
        public HttpResponseMessage Inserir([FromBody] IngredienteInserirViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido");

            var dtoReturn = _service.Inserir(viewModel);

            if (dtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, dtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, dtoReturn.Ingrediente);
        }

        [HttpPut]
        [Route("")]
        public HttpResponseMessage Editar([FromBody] IngredienteAtualizarViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

            var dtoReturn = _service.Atualizar(viewModel);

            if (dtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, dtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, dtoReturn.Ingrediente);
        }

        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage Delete(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

            _service.Excluir(id);

            return Request.CreateResponse(HttpStatusCode.NoContent);
        }
    }
}