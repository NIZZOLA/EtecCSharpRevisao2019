using System;
using System.ComponentModel.DataAnnotations;

namespace Aplicacao1
{
    public class Funcionario
    {
        [Key]
        public int FuncionarioId { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }
        [MaxLength(50)]
        public string Cargo { get; set; }
        [MaxLength(15)]
        public string Fone { get; set; }
        [MaxLength(80)]
        public string Email { get; set; }
        [MaxLength(10)]
        public string Senha { get; set; }
        public DateTime Nascimento { get; set; }
        public bool Ativo { get; set; }
    }
}
