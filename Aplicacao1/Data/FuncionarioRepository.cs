using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao1.Data
{
    public class FuncionarioRepository
    {
        private AppEstoqueContext ctx;

        public FuncionarioRepository()
        {
            ctx = new AppEstoqueContext();
        }
        
        public void Incluir( Funcionario fun )
        {
            ctx.Funcionarios.Add(fun);
            ctx.SaveChanges();
        }

        public void Alterar( Funcionario fun )
        {
            Funcionario funcad = this.Consultar( fun.FuncionarioId);
            funcad.Cargo = fun.Cargo;
            funcad.Ativo = fun.Ativo;
            funcad.Email = fun.Email;
            funcad.Fone = fun.Fone;
            funcad.Nascimento = fun.Nascimento;
            funcad.Nome = fun.Nome;
            funcad.Senha = fun.Senha;

            // anexa novamente ao contexto o funcionario que veio e teve as propriedades alteradas
            ctx.Funcionarios.Attach(funcad);
            // informa o entity que o estado do objeto "funcad" é "modificado"
            ctx.Entry(funcad).State = System.Data.Entity.EntityState.Modified;
            // salva as alterações
            ctx.SaveChanges();
        }

        public bool Excluir( int codigo )
        {
            // obtem um objeto referente ao codigo 
            Funcionario funcad = this.Consultar(codigo);
            // só realiza a operação caso o funcionario do codigo não seja nulo
            if (funcad != null)
            {
                // informa o contexto para remover o objeto
                ctx.Funcionarios.Remove(funcad);
                // salva as alterações
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public Funcionario Consultar( int codigo )
        {
            Funcionario fun = ctx.Funcionarios.Where(a => a.FuncionarioId == codigo).FirstOrDefault();
            return fun;
        }
    }
}
