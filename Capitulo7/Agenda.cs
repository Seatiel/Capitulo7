using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capitulo7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> hash = new Dictionary<string, string>();

        private void Añadirbutton_Click(object sender, EventArgs e)
        {
            hash.Add(NombretextBox.Text, TelefonomaskedTextBox.Text);
            if (String.IsNullOrEmpty(NombretextBox.Text) || String.IsNullOrEmpty(TelefonomaskedTextBox.Text))
                MessageBox.Show("Ambos campos tienen que ser llenados");
            else
                listBox1.Items.Add(String.Format("{0}\t{1}", NombretextBox.Text, TelefonomaskedTextBox.Text));
        }
    }
}
