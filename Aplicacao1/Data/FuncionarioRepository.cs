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

        }

        public void Excluir( int codigo )
        {
            
        }

        public Funcionario Consultar( int codigo )
        {
            Funcionario fun = ctx.Funcionarios.Where(a => a.FuncionarioId == codigo).FirstOrDefault();
            return fun;
        }
    }
}
