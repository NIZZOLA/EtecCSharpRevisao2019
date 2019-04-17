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

namespace Aplicacao1
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        public void CarregarItem( int codigo )
        {
            ProdutoRepository prodData = new ProdutoRepository();
            Produto prod = prodData.Consultar(codigo);

            txtDescri.Text = prod.Descricao;
            txtCusto.Text = prod.Custo.ToString();
            txtMargem.Text = prod.Margem.ToString();
            txtEstoque.Text = prod.Estoque.ToString();
            txtVenda.Text = prod.ValorVenda.ToString();
            txtCodigo.Text = prod.ProdutoId.ToString();

            txtCodigo.Visible = true;
            lblCodigo.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Produto prod = new Produto();
            var resposta = prod.ValidarCadastro(txtDescri.Text, txtCusto.Text, txtMargem.Text,
                 txtVenda.Text, txtEstoque.Text);

            if ( ! resposta.Item1  )
            {
                ProdutoRepository prodData = new ProdutoRepository();
                prodData.Incluir(prod);

            }
            else
            {
                MessageBox.Show("Não foi possível validar os itens "+ resposta.Item2 );
            }


        }

   

        private void frmProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
