using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diccionario
{
    public partial class Diccionario : Form
    {
        public Diccionario()
        {
            InitializeComponent();
        }

        Dictionary<string, string> hash = new Dictionary<string, string>();

        private void Añadirbutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NombretextBox.Text) || String.IsNullOrEmpty(DefiniciontextBox.Text))
                MessageBox.Show("Ambos campos tienen que ser llenados");
            else
            {
                hash.Add(NombretextBox.Text, DefiniciontextBox.Text);
                hashBox.Items.Add(String.Format("{0}\t\t{1}", data.Key, data.Value));
            }
        }
    }
}
