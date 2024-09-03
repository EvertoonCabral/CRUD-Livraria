using System.ComponentModel.DataAnnotations;

namespace EmprestimoLivraria.Models
{
    public class EmprestimosModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="Favor informar quem é o Recebedor")]
        public string Recebedor { get; set; }

        [Required(ErrorMessage = "Favor informar quem é o Fornecedor")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "Qual o Livro Emprestado?")]
        public string  LivroEmprestado { get; set; }
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;





    }
}
