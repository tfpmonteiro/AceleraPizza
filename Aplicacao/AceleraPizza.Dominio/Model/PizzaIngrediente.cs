namespace AceleraPizza.Dominio.Model
{
    public class PizzaIngrediente : EntidadeDominio
    {
        public Ingrediente Ingredientes { get; set; }
        public Pizza Pizza { get; set; }
        public int Quantidade { get; set; }
    }
}
