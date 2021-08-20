using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1608
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExec02_Click(object sender, EventArgs e)
        {
            new Exec02().Show();
            this.Hide();
        }

        private void btnExec01FM_Click(object sender, EventArgs e)
        {
            new Exec03FM().Show();
            this.Hide();
        }
    }
}
