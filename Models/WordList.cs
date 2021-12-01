namespace Lab3FrajeTest2Console.Models
{
    class WordList
    {
        private WordListModel wordListModel;
        public string Name { get { return wordListModel.Name; } }
        public string[] Languages { get { return wordListModel.Languages; } }

        public WordList(string name, string languageOne, string languageTwo)
        {
            
            wordListModel = new WordListModel();
            wordListModel.Name = name;
            wordListModel.Languages = new string[] { languageOne, languageTwo };
        }

        public void addWord(string languageOneWord, string languageTwoWord)
        {
            var word = new WordModel(new string[] { languageOneWord, languageTwoWord });
            wordListModel.Words.Add(word);
        }
    }
}
