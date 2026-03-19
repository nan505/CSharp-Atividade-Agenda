using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_agenda
{
    public partial class fmCadastroPokemon : Form
    {
        public fmCadastroPokemon()
        {
            InitializeComponent();
        }

        private void fnLimparFormularios()
        {
            txtNome.Clear();
            cbTipo.SelectedIndex = -1;
            numNivel.Value = 1;

            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomePokemon = txtNome.Text;
            string tipoPokemon = cbTipo.Text;
            int nivelPokemon = (int)numNivel.Value;

            if(nomePokemon != string.Empty && tipoPokemon != string.Empty)
            {
                MessageBox.Show($"O Pokémon {nomePokemon} do tipo {tipoPokemon} foi cadastrado com o nível {nivelPokemon}.",
                "Mensagem de Aviso");

                fnLimparFormularios();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Mensagem de Aviso");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            fnLimparFormularios();
        }
    }
}
