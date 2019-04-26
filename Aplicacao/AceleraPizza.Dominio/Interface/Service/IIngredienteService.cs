using AceleraPizza.Dominio.Dto;
using AceleraPizza.Dominio.View;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Interface.Service
{
    public interface IIngredienteService
    {
        IngredienteDtoReturn Inserir(IngredienteInserirViewModel ingredienteViewModel);
        IngredienteDtoReturn Atualizar(IngredienteAtualizarViewModel ingredienteViewModel);
        IngredienteDto BuscarPorId(Guid id);
        List<IngredienteSearchDto> BuscarTodos();
        void Excluir(Guid id);
    }
}
