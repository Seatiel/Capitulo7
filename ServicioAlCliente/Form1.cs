using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ServicioAlCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue<string> cliente = new Queue<string>();

        private void Añadirbutton_Click(object sender, EventArgs e)
        {
            cliente.Enqueue(ClientetextBox.Text);

            foreach (string c in cliente)
            {
                listBox.Items.Add(c);
            }
            cliente.Dequeue();
        }

        private void Atenderbutton_Click(object sender, EventArgs e)
        {
            listBox.Items.RemoveAt(0);
        }
    }
}
