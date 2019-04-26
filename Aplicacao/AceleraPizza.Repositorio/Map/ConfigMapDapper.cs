using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceleraPizza.Repositorio.Map
{
    public class ConfigMapDapper
    {
        private static bool _carregado;

        public static void Carregar()
        {
            if (_carregado) return;

            FluentMapper.Initialize(config =>
           {
               config.AddMap(new ClienteMap());
               config.AddMap(new IngredienteMap());
               config.ForDommel();
           });

            _carregado = true;
        }
    }
}
