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

        private void button1_Click(object sender, EventArgs e)
        {
            decimal custo=0, margem=0, estoque=0, venda;
            Boolean erro = false;

            if (txtCusto.Text == "")
            {
                MessageBox.Show("O valor de custo é obrigatório ");
                erro = true;
            }
            else
            {
                if( ! Decimal.TryParse(txtCusto.Text, out custo ) )
                {
                    MessageBox.Show("O valor de custo não é um número válido ");
                    erro = true;
                }
            }

            if (txtMargem.Text == "")
            {
                MessageBox.Show("A margem de lucro é obrigatória !");
                erro = true;
            }
            else
            {
                if (!Decimal.TryParse(txtMargem.Text, out margem))
                {
                    MessageBox.Show("O valor de custo não é um número válido ");
                    erro = true;
                }
            }

            if( txtEstoque.Text == "" )
            {
                MessageBox.Show("O campo estoque é obrigatório !");
                erro = true;
            }
            else
            {
                if (!Decimal.TryParse(txtEstoque.Text, out estoque))
                {
                    MessageBox.Show("O estoque não é um número válido ");
                    erro = true;
                }
            }


            if (!erro)
            {
                venda = custo + (custo * margem / 100);
                txtVenda.Text = venda.ToString("###,##0.00");

                Produto prod = new Produto();
                prod.Descricao = txtDescri.Text;
                prod.Custo = custo;
                prod.Margem = margem;
                prod.ValorVenda = venda;
                prod.Estoque = estoque;

                if (! prod.PodeVender(10))
                    MessageBox.Show("não há itens suficientes no estoque ");


            }


        }
    }
}
