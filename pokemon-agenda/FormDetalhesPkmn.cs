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
    public partial class FormDetalhesPkmn : Form
    {
        public Pokemon pkmnRecebido { get; set; }

        public FormDetalhesPkmn()
        {
            InitializeComponent();
        }

        private void FormDetalhesPkmn_Load(object sender, EventArgs e)
        {
            lbNome.Text = "Nome: " + pkmnRecebido.NomePkmn;
            lbTipo.Text = "Tipo: " + pkmnRecebido.TipoPkmn;
            lbNivel.Text = "Nível: " + pkmnRecebido.NivelPkmn.ToString();
        }
    }
}
