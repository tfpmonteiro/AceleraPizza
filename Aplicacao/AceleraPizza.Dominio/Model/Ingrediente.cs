namespace AceleraPizza.Dominio.Model
{
    public class Ingrediente: EntidadeDominio
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public Ingrediente()
        {

        }

        public Ingrediente(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
            ValidarCadastro();
        }

        private void ValidarCadastro()
        {
            if (string.IsNullOrWhiteSpace(Descricao))
                AdicionarErro("Por favor, preencha o campo com a descrição do ingrediente.");

            if (Valor <= 0.00)
                AdicionarErro("Por favor, informe o valor do ingrediente.");
        }
    }
}