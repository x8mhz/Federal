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
    public partial class fm_CadastrarCliente : Form
    {
        public fm_CadastrarCliente()
        {
            InitializeComponent();
        }

        private void federalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // NÃO USO
            this.Validate();
            this.federalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.federalDataSet);

        }

        private void fm_CadastrarCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'federalDataSet.Federal' table. You can move, or remove it, as needed.
            this.federalTableAdapter.Fill(this.federalDataSet.Federal);
            this.bindingNavigatorAddNewItem.PerformClick();

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.federalBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.federalDataSet);
                this.bindingNavigatorAddNewItem.PerformClick();
                MessageBox.Show("Cliente salvo com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cliente NÃO foi salvo. Feche a tela de cadastro e abra novamente.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
}
