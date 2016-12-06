using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Federal
{
    public partial class fm_BuscarCliente : Form
    {
        public fm_BuscarCliente()
        {
            InitializeComponent();
        }

        private void fm_CadastroCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'federalDataSet.Federal' table. You can move, or remove it, as needed.
            this.federalTableAdapter.Fill(this.federalDataSet.Federal);

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_BuscarNome.Clear();
            txt_BuscarCPF.Clear();
        }

        private void txt_BuscarNome_TextChanged(object sender, EventArgs e)
        {
            this.federalTableAdapter.FillByBuscarNome(federalDataSet.Federal, txt_BuscarNome.Text);
        }

        private void txt_BuscarCPF_TextChanged(object sender, EventArgs e)
        {
            this.federalTableAdapter.FillByBuscarCPF(federalDataSet.Federal, txt_BuscarCPF.Text);
        }
    }
}
