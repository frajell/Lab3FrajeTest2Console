using System;
using System.Collections.Generic;

namespace Lab3FrajeTest2Console.Models
{
    class WordListModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string[] Languages { get; set; }
        public List<WordModel> Words { get; set; }

        public WordListModel ()
        {
            Words = new List<WordModel>();
        }
    }
}
