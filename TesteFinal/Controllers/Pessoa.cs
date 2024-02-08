using System.ComponentModel.DataAnnotations;

namespace TesteFinal.Controllers
{
    public class Pessoa
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(14)]
        public string Cpf { get; set; }
        public DateOnly DataNascimento { get; set; }
    }
}
