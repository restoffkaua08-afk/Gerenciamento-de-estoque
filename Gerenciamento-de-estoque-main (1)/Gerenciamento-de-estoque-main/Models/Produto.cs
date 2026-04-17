namespace estoque_s_a
{

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Codigo { get; set; } = "";
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}