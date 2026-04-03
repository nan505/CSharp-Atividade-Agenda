using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_agenda
{
    public class Pokemon
    {
        public string NomePkmn { get; set; }
        public string TipoPkmn { get; set; }
        public int NivelPkmn { get; set; }
        public int VidaPkmn { get; set; }
        public int DanoPkmn { get; set; }

        // Criação da função de inicialização padrão do meu objeto.


        /// <summary>
        /// Inicializa o construtor da minha classe padrão de <c>Pokémon</c>.
        /// <paramref name="nomePokemon"/>, <paramref name="tipoPokemon"/>, <paramref name="nivelPokemon"/>
        /// <list type="bullet">
        /// <item>nomePokemon: Variável para saber o nome do Pokémon</item>
        /// <item>tipoPokemon: Variável para saber o tipo do Pokémon</item>
        /// <item>nivelPokemon: Variável para saber o nível do Pokémon</item>
        /// </list>
        /// </summary>
        /// <returns>
        /// A função <see cref="fnDescricao"/> não retorna nada.
        /// </returns>
        /// <param name="nomePokemon">Vai ser o nome que o Pokémon vai ser chamado.</param>
        /// <param name="tipoPokemon">Define o tipo do elemento que o Pokémon possui afinidade.</param>
        /// <param name="nivelPokemon">Define o nível atual do Pokémon.</param>
        public Pokemon(string nomePokemon, string tipoPokemon, int nivelPokemon)
        {
            NomePkmn = nomePokemon;
            TipoPkmn = tipoPokemon;
            NivelPkmn = nivelPokemon;
            VidaPkmn = 100 + (nivelPokemon * 2);
            DanoPkmn = 20 + nivelPokemon;
        }

        /// <summary>
        /// Exibe uma caixa de mensagem com todas as informações sobre o <c>Pokémon</c> escolhido.
        /// <list type="bullet">
        /// <item>Nome do Pokémon</item>
        /// <item>Tipo do Pokémon</item>
        /// <item>Nível do Pokémon</item>
        /// <item>Vida do Pokémon</item>
        /// <item>Ataque do Pokémon</item>
        /// </list>
        /// </summary>
        /// <returns>Essa função não retorna nada.</returns>
        public void fnDescricao()
        {
            MessageBox.Show($"Pokémon: {NomePkmn}\nTipo: {TipoPkmn}\nNível: {NivelPkmn}\nVida: {VidaPkmn}\n" +
                $"Ataque: {DanoPkmn}", "Informações");
        }
    }
}
