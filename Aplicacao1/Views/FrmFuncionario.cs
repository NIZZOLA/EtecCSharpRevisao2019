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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        public FrmFuncionario(int codigo )
        {
            InitializeComponent();
            FuncionarioRepository funRepo = new FuncionarioRepository();
            var funcionario = funRepo.Consultar(codigo);
            if( funcionario == null )
            {
                MessageBox.Show("Funcionário não encontrado !");
            }
            else
            {
                txtCodigo.Text = funcionario.FuncionarioId.ToString();
                txtNome.Text = funcionario.Nome;
                txtEmail.Text = funcionario.Email;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario fun = new Funcionario();
            var erros = fun.Validar(txtCodigo.Text, txtNome.Text, txtSenha.Text, chkAtivo.Checked, txtCargo.Text
                , txtEmail.Text, mskFone.Text, mskNascimento.Text);
            
            if( erros.Count == 0 )
            {
                if (MessageBox.Show("Deseja Gravar?", "SALVAR",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FuncionarioRepository funRepo = new FuncionarioRepository();
                    if (fun.FuncionarioId == 0)
                        funRepo.Incluir(fun);
                    else
                        funRepo.Alterar(fun);
                    this.Close();
                }
            }
            else
            {
                foreach (var item in erros)
                {
                    MessageBox.Show(item);
                }
            }


        }
    }
}
