using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListadeContatosT7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.Nome = NOME.Text;
            contato.Sobrenome = SOBRENOME.Text;
            contato.Telefone = TELEFONE.Text;

            listBoxContatos.Items.Add(contato.ToString());
        }
    }
}
