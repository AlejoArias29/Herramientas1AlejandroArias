using libreria.libro;
using libreria.Transaccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new crear();
            form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new buscar();
            form.ShowDialog();
            this.Close();
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            var form = new Transacciones();
            form.ShowDialog();
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            var form = new Reporte();
            form.ShowDialog();
            this.Close();
        }
    }
}
