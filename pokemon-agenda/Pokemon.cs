using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_agenda
{
    internal class Pokemon
    {
        string NomePkmn;
        string TipoPkmn;
        int NivelPkmn;
        int VidaPkmn;
        int DanoPkmn;

        // Criação da função de inicialização padrão do meu objeto.

        public Pokemon(string nomePokemon, string tipoPokemon, int nivelPokemon)
        {
            NomePkmn = nomePokemon;
            TipoPkmn = tipoPokemon;
            NivelPkmn = nivelPokemon;
            VidaPkmn = 100 + (nivelPokemon * 2);
            DanoPkmn = 20 + nivelPokemon;
        }

        public void fnDescricao()
        {
            MessageBox.Show($"Pokémon: {NomePkmn}\nTipo: {TipoPkmn}\nNível: {NivelPkmn}\nVida: {VidaPkmn}\n" +
                $"Ataque: {DanoPkmn}", "Informações");
        }
    }
}
