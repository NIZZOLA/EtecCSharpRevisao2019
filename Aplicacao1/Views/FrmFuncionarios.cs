using Aplicacao1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacao1.Views
{
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void mnuIncluir_Click(object sender, EventArgs e)
        {
            FrmFuncionario form = new FrmFuncionario();
            form.Show();
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            carregarTodos();
        }

        private void carregarTodos()
        {
            FuncionarioRepository funRepo = new FuncionarioRepository();
            var lista = funRepo.ConsultarTodos();
            gridFun.DataSource = lista;
        }

        private void mnuExcluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(gridFun.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Confirma ?", "EXCLUSAO DO ITEM " + codigo
                , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FuncionarioRepository funRepo = new FuncionarioRepository();
                if (!funRepo.Excluir(codigo))
                {
                    MessageBox.Show("Erro ao excluir o código" + codigo + " !");
                }
                carregarTodos();
            }
        }

        private void mnuAbrir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(gridFun.CurrentRow.Cells[0].Value);

            FrmFuncionario tela = new FrmFuncionario(codigo);
            tela.Show();

        }
    }
}
