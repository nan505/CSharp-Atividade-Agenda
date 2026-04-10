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
            VidaPkmn = 100 + (nivelPokemon * 3);
            DanoPkmn = 20 + (nivelPokemon * 3);
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

        /// <summary>
        /// Faz o tratamento do nome do Pokémon desejado para retornar a URL da imagem já tratada.
        /// </summary>
        /// <returns>Retorna a URL da imagem do Pokémon desejado como string.</returns>
        public string fnLinkImg()
        {
            string nomePkmnTratado = NomePkmn.Replace(" ", "-").Replace(".", "").ToLower();

            return $"https://img.pokemondb.net/artwork/{nomePkmnTratado}.jpg";
        }


        /// <summary>
        /// Treina o Pokémon desejado, aumentando seu nível em 1 caso o nível atual do Pokémon seja menor que 100.
        /// </summary>
        /// <returns>Essa função não retorna nada.</returns>
        public void fnTreinarPkmn()
        {
            if(NivelPkmn < 100)
            {
                NivelPkmn++;
                VidaPkmn = VidaPkmn + 20;
                DanoPkmn = DanoPkmn + 20;
            }
            else
            {
                MessageBox.Show($"O Pokémon {NomePkmn} já está no nível máximo (100).", "Mensagem de Aviso");
            }
        }
    }
}
