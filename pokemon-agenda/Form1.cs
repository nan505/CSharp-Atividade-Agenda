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
        BindingList<Pokemon> listaPokemon = new BindingList<Pokemon>();
        public fmCadastroPokemon()
        {
            InitializeComponent();

            Pokemon p1 = new Pokemon("Pikachu", "Elétrico", 29);
            Pokemon p2 = new Pokemon("Charmander", "Fogo", 6);
            Pokemon p3 = new Pokemon("Bulbasaur", "Grama", 12);
            Pokemon p4 = new Pokemon("Squirtle", "Água", 13);

            listaPokemon.Add(p1);
            listaPokemon.Add(p2);
            listaPokemon.Add(p3);
            listaPokemon.Add(p4);

            dgvListaPokemon.DataSource = listaPokemon;
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

            Pokemon novoPokemon = new Pokemon(nomePokemon, tipoPokemon, nivelPokemon);
            if(nomePokemon != string.Empty && tipoPokemon != string.Empty)
            {
                listaPokemon.Add(novoPokemon);

                MessageBox.Show($"O Pokémon {nomePokemon} do tipo {tipoPokemon} foi cadastrado com o nível {nivelPokemon}.",
                "Mensagem de Aviso");

                novoPokemon.fnDescricao();

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

        private void btnAjuda_Click(object sender, EventArgs e)
        {

        }
    }
}
