namespace ModelsLibrary
{
    public static class Helper
    {
        public static string Pluralize(string word)
        {
            if (word.ToLower() == "person")
            {
                return "People";
            }

            int wordLength = word.Length;

            // Words ending in 'y'
            if (word.Substring(wordLength-1, 1).ToLower() == "y")
            {
                var result = word.Substring(0, wordLength) + "ies";
                return result;
            }

            // Words ending in 'ch'
            if (word.Substring(wordLength-2, 2).ToLower() == "ch")
            {
                var result = word.Substring(0, wordLength-1) + "es";
                return result;
            }

            //TODO:  Add other possible pluralization

            // Default:
            return word + "s";
        }
    }
}
