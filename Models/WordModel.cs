namespace Lab3FrajeTest2Console.Models
{
    class WordModel
    {
        public string[] Translations { get; set; }
        public int FromLanguage { get; }
        public int ToLanguage { get; }
        public WordModel(params string[] translations)
        {
            Translations = translations;
        }
        public WordModel(int fromLanguage, int toLangague, params string[] translations)
        {

        }
    }
}
