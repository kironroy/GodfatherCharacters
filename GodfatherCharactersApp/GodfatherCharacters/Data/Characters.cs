using System.Collections.Generic;

namespace GodfatherCharacters.Data
{
    public class Character
    {
        public string FullName { get; set; }
        public string PlayedBy { get; set; }
        public string Family { get; set; }
    }

    public static class Characters
    {
        public static IEnumerable<Character> GetCharacters()
        {
            yield return new Character
            {
                FullName = "Vito Corleone",
                PlayedBy = "Marlon Brando",
                Family = "Corleone"
            };

            yield return new Character
            {
                FullName = "Emilio Barzini",
                PlayedBy = "Richard Conte",
                Family = "Barzini"
            };

            yield return new Character
            {
                FullName = "Bruno Tattaglia",
                PlayedBy = "Tony Giorgio",
                Family = "Tattaglia"
            };

        }
    }

}
