using CommandDotNet.Attributes;
using ConsoleTables;
using GodfatherCharacters.Data;
using System.Linq;

namespace GodfatherCharacters
{
    public class GodfatherChars
    {
        [ApplicationMetadata(Description = "Lists the films")]
        public void Films()
        {
            ConsoleTable
                .From(Movies.GetMovies())
                .Write();
        }

        [ApplicationMetadata(Description = "Lists the individual mafisos")]
        public void Mafioso(string family = "")
        {
            var characters = Characters.GetCharacters()
                .Where(mafiso => mafiso.Family.Contains(family));

            ConsoleTable
               .From(characters)
               .Write();
        }
    }
}
