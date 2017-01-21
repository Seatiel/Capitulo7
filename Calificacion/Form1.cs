using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calificacion
{
    public partial class Calificacion : Form
    {
        public Calificacion()
        {
            InitializeComponent();
        }

        List<int> list = new List<int>();

        private void Añadirbutton_Click(object sender, EventArgs e)
        {
            list.Add(int.Parse(CalificaciontextBox.Text));
            listBox.Items.Add(CalificaciontextBox.Text);
            foreach (int n in list)
            {
                CalificacionAltatextBox.Text = list.Max().ToString();
                CalificacionBajatextBox.Text = list.Min().ToString();
                PromediotextBox.Text = list.Average().ToString();
            }
        }
    }
}
