using System;
using System.Collections.Generic;
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


        public List<string> Validar( string codigo, string nome, string senha, bool ativo, string cargo,
            string email, string fone, string nascimento )
        {
            List<string> messages = new List<string>();
            if( codigo != "" )
            {
                if (!int.TryParse(codigo, out int codigoEdit))
                    messages.Add("Codigo digitado não válido !");
                FuncionarioId = codigoEdit;
            }


            if( nome == "" )
            {
                messages.Add("O nome é um campo obrigatório !");
            }
            else
            {
                if (nome.Length > 50)
                    messages.Add("O nome não pode ultrapassar 50 caracteres!");
            }

            if( senha == "" )
            {
                messages.Add( "A senha é um campo obrigatório !" );
            }
            else
            {
                if (senha.Length < 6 || senha.Length > 10)
                    messages.Add("A senha deve ter entre 6 a 10 dígitos !");
            }


            if( email == "" )
            {
                messages.Add("O email deve ser preenchido !");
            }
            else
            {
                if (email.Length > 80)
                    messages.Add("O email não pode ultrapassar 80 caracteres !");
            }

            if( ! DateTime.TryParse( nascimento, out DateTime dataNasc ))
            {
                messages.Add("A data de nascimento não é válida !");
            }
            else
            {
                Nascimento = dataNasc;
            }
                        
            Nome = nome;
            Senha = senha;
            Ativo = ativo;
            Cargo = cargo;
            Email = email;
            Fone = fone;
            
            return messages;
        }
    }
}
