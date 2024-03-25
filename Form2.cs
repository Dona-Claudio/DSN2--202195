using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSN2_202195
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            textBoxCodigo.Text = "";
            textBoxNome.Text = "";
            listBoxCategoria.SelectedIndex = -1;
            listBoxFornecedor.SelectedIndex = -1;
            buttonNovo.Enabled = false;
            buttonSalvar.Enabled = true;
            buttonCancelar.Enabled = true;
            textBoxCodigo.Focus();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try {
                if (String.IsNullOrWhiteSpace(textBoxNome.Text) ||
                String.IsNullOrWhiteSpace(textBoxNome.Text) ||
                String.IsNullOrWhiteSpace(textBoxNome.Text) ||
                String.IsNullOrWhiteSpace(textBoxNome.Text))
                {
                    MessageBox.Show("Preencha todos os campos!", "aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    groupBox1.Enabled = false;
                    buttonNovo.Enabled = true;
                    buttonSalvar.Enabled = false;
                    buttonCancelar.Enabled = false;
                }
            } catch (Exception ex) {
                MessageBox.Show("ocorreu um erro inesperado" + ex.Message, "erro de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            buttonNovo.Enabled = true;
            buttonSalvar.Enabled = false;
            buttonCancelar.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           groupBox1.Enabled = false;
            buttonNovo.Enabled = true;
            buttonSalvar.Enabled = false;
            buttonCancelar.Enabled = false;
           
        }
    }
}
