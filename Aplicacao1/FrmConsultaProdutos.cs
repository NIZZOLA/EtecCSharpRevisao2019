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
    public partial class FrmConsultaProdutos : Form
    {
        public FrmConsultaProdutos()
        {
            InitializeComponent();
        }

        private void FrmConsultaProdutos_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            ProdutoRepository prodData = new ProdutoRepository();
            var produtos = prodData.ConsultarTodos();
            grid1.DataSource = produtos;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmProduto tela = new frmProduto();
            tela.ShowDialog();
            CarregaGrid();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            // CurrentRow = linha atual
            // Cells = conjunto de colunas daquela linha
            // value = valor contido na célula
            int codigo = Convert.ToInt32( grid1.CurrentRow.Cells[0].Value);

            frmProduto tela = new frmProduto();
            tela.CarregarItem(codigo);
            tela.ShowDialog();
            CarregaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(grid1.CurrentRow.Cells[0].Value);

            if( MessageBox.Show("Exclusão do item:" + codigo, "Confirma ?",
                MessageBoxButtons.YesNo) == DialogResult.Yes )
            {
                ProdutoRepository prodData = new ProdutoRepository();
                prodData.Excluir(codigo);
                CarregaGrid();
            }
        }
    }
}
