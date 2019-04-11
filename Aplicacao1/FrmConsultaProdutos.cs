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
            ProdutoRepository prodData = new ProdutoRepository();
            var produtos = prodData.ConsultarTodos();
            grid1.DataSource = produtos;
        }
    }
}
