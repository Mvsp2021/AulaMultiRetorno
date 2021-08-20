using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1608
{
    public partial class Exec02 : Form
    {
        public Exec02()
        {
            InitializeComponent();
        }

        private void rbEntrando_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEntrando.Checked)
            {
                lblVagas.Text = "Vagas Livres";
                lblPlaca.Visible = true;
                txtPlaca.Visible = true;

                lblHora.Visible = true;
                txtHora.Visible = true;

                AtualizaCB(true);
            }

        }

        private void rbSaindo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSaindo.Checked)
            {
                lblVagas.Text = "Placas dos veículos";
                lblPlaca.Visible = false;
                txtPlaca.Visible = false;
                AtualizaCB(false);
            }

        }


        private void btnExecuta_Click(object sender, EventArgs e)
        {
            if (rbEntrando.Checked)
            {
                // Entrando

                string update = $"UPDATE dbo.Vaga Set PlacaDoVeiculo = '{txtPlaca.Text}', EstaPreenchida = 1 WHERE NumeroDaVaga = '{cbVagasLivres.Text}'";
                DBFunction.GenericExecute(update);
                AtualizaCB(true);
                txtPlaca.Clear();

            }
            else
            {
                // Sair

                string update = $"UPDATE dbo.Vaga Set PlacaDoVeiculo = null, EstaPreenchida = 0 WHERE PlacaDoVeiculo = '{cbVagasLivres.Text}'";
                DBFunction.GenericExecute(update);
                AtualizaCB(false);

            }
            AtualizaDG();
            cbVagasLivres.Text = null;

        }

        private void Exec02_Load(object sender, EventArgs e)
        {
            AtualizaDG();
            AtualizaCB(true);

            rbEntrando.Checked = true;

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AtualizaDG()
        {
            dgVagas.Rows.Clear();

            string select = "SELECT * from dbo.Vaga";
            //DBFunction.Connection == Cadeia de conexão
            SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
            DBFunction.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                string[] vetor = { dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                dgVagas.Rows.Add(vetor);

            }
            dr.Close();
            DBFunction.Connection.Close();

        }

        private void AtualizaCB(bool update)
        {
            cbVagasLivres.Items.Clear();
            cbVagasLivres.Text = null;

            if (update) //atualiza as vagas livres
            {
                //string select = "SELECT NumeroDaVaga from dbo.Vaga WHERE EstaPreenchida = 0";
                //SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
                //DBFunction.Connection.Open();
                //SqlDataReader dr = cmd.ExecuteReader();
                //while (dr.Read())
                //{
                //    cbVagasLivres.Items.Add(dr[0].ToString());
                //}
                //dr.Close();
                //DBFunction.Connection.Close();

                foreach (var item in DBFunction.GenericUnitSelect("NumeroDaVaga", "Vaga", "EstaPreenchida = 0"))
                {
                    cbVagasLivres.Items.Add(item);
                }
            }
            else //mostra as placas atuais
            {
                List<string> lista = DBFunction.GenericUnitSelect("PlacaDoVeiculo", "Vaga", "EstaPreenchida = 1");
                lista.Sort();

                foreach (var item in lista)
                {
                    cbVagasLivres.Items.Add(item);

                }

            }


        }

    }
}
