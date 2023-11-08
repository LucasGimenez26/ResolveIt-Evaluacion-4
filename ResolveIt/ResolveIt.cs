using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResolveIt
{
    public partial class ResolveIt : Form
    {

        public ResolveIt()
        {
            InitializeComponent();
        }

        private void btGo_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();

            calc.ShowDialog();
        }
    }
}
