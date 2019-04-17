using AceleraPizza.Dominio.Dto;
using AceleraPizza.Dominio.View;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Interface.Service
{
    public interface IClienteService
    {
        ClienteDtoReturn Inserir(ClienteInserirViewModel clienteViewModel);
        ClienteDto BuscarPorId(Guid id);
        List<ClienteSearchDto> BuscarTodos();
        ClienteDtoReturn Atualizar(ClienteAtualizarViewModel cliente);
        void Excluir(Guid id);
    }
}
