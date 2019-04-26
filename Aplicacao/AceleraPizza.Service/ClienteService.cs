using AceleraPizza.Dominio.Dto;
using AceleraPizza.Dominio.Interface.Repositorio;
using AceleraPizza.Dominio.Interface.Service;
using AceleraPizza.Dominio.Model;
using AceleraPizza.Dominio.View;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Service
{
    public class ClienteService : IClienteService
    {
        private IClienteRepositorio _repositorio;

        public ClienteService(IClienteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public ClienteDtoReturn Inserir(ClienteInserirViewModel clienteViewModel)
        {
            var cliente = new Cliente(clienteViewModel.Nome, clienteViewModel.Cpf, clienteViewModel.Telefone, 
                clienteViewModel.DataNascimento, clienteViewModel.Endereco);

            if (!cliente.Valido())
                return new ClienteDtoReturn(cliente.GetErros());

            cliente.GerarId();
            _repositorio.Inserir(cliente);

            return new ClienteDtoReturn(BuscarPorId(cliente.Id));
        }

        public ClienteDto BuscarPorId(Guid id)
        {
            Cliente cliente = _repositorio.BuscarPorId(id);

            if (cliente == null)
                return null;

            return new ClienteDto
            {
                Id = cliente.Id,
                Cpf = cliente.Cpf,
                DataNascimento = cliente.DataNascimento,
                Nome = cliente.Nome,
                Telefone = cliente.Telefone,
                Endereco = cliente.Endereco
            };
        }

        public List<ClienteSearchDto> BuscarTodos()
        {
            List<Cliente> clientes = _repositorio.BuscarTodos();
            List<ClienteSearchDto> retorno = new List<ClienteSearchDto>();

            foreach (var cliente in clientes)
            {
                retorno.Add(new ClienteSearchDto
                {
                    id = cliente.Id,
                    Cpf = cliente.Cpf,
                    Nome = cliente.Nome
                });
            }

            return retorno;
        }

        public ClienteDtoReturn Atualizar(ClienteAtualizarViewModel clienteAtualizarViewModel)
        {
            var cliente = _repositorio.BuscarPorId(clienteAtualizarViewModel.Id);

            if(cliente == null)
            {
                var erros = new List<string>();
                erros.Add("Cliente não existe");
                return new ClienteDtoReturn(erros);
            }

            cliente.Endereco = clienteAtualizarViewModel.Endereco;
            cliente.Telefone = clienteAtualizarViewModel.Telefone;

            if (!cliente.Valido())
                return new ClienteDtoReturn(cliente.GetErros());

            _repositorio.Atualizar(cliente);

            return new ClienteDtoReturn(BuscarPorId(cliente.Id));
        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }

    }
}
