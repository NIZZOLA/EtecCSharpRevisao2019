using Aplicacao1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao1
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [MaxLength(80)]
        [Required]
        public string Descricao { get; set; }
        [Required]
        public decimal Custo { get; set; }
        [Required]
        public decimal Margem { get; set; }
        [Required]
        public decimal ValorVenda { get; set; }
        [Required]
        public decimal Estoque { get; set; }

        public bool PodeVender(decimal quantidade)
        {
            if (Estoque >= quantidade)
                return true;
            else
                return false;
        }

        public Tuple<bool, string> ValidarCadastro(string descri, string custo, string margem,
            string venda, string estoque)
        {
            Boolean erro = false;
            string mensagem = "";
            Decimal novoCusto = 0, novaMargem = 0, novoEstoque = 0;
            if( descri == "" )
            {
                mensagem += "O campo descrição não pode ser vazio !";
                erro = true;
            }

            if (custo == "")
            {
                mensagem += "O valor de custo é obrigatório ";
                erro = true;
            }
            else
            {
                if (!Decimal.TryParse(custo, out novoCusto))
                {
                    mensagem += "O valor de custo não é um número válido \n";
                    erro = true;
                }
            }

            if (margem == "")
            {
                mensagem += "A margem de lucro é obrigatória !\n";
                erro = true;
            }
            else
            {
                if (!Decimal.TryParse(margem, out novaMargem))
                {
                    mensagem += "O valor de custo não é um número válido \n";
                    erro = true;
                }
            }

            if (estoque == "")
            {
                mensagem += "O campo estoque é obrigatório !\n";
                erro = true;
            }
            else
            {
                if (!Decimal.TryParse(estoque, out novoEstoque))
                {
                    mensagem += "O estoque não é um número válido ";
                    erro = true;
                }
            }

            this.Descricao = descri;
            this.Custo = novoCusto;
            this.Margem = novaMargem;
            this.ValorVenda = novoCusto + (novoCusto * novaMargem / 100);
            this.Estoque = novoEstoque;

            return new Tuple<bool, string> ( erro, mensagem );
        }

    }
}
