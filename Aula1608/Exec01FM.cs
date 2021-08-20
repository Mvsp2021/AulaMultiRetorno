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
    public partial class Exec03FM : Form
    {
        public Exec03FM()
        {
            InitializeComponent();
        }

        private void btnVai_Click(object sender, EventArgs e)
        {
            if (rbExec03.Checked)
            {
                new Exec03().Show();
                this.Hide();

            }
        }
    }
}
