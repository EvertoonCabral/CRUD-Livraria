namespace EmprestimoLivraria.Models
{
    public class EmprestimosModel
    {

        public int Id { get; set; }
        public string Recebedor { get; set; }
        public string Fornecedor { get; set; }
        public string  LivrroEmprestado { get; set; }
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;





    }
}
