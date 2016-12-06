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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adicionarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_CadastrarCliente fm_cadastrarCliente = new fm_CadastrarCliente();
            fm_cadastrarCliente.Show();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm_BuscarCliente fm_buscarCliente = new fm_BuscarCliente();
            fm_buscarCliente.Show();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.Copy(Application.StartupPath.ToString() + "\\BD_Federal.mdb", saveFileDialog1.FileName);
                    MessageBox.Show("Exportado com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível exportar o arquivo.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void blocoDeNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }
    }
}
