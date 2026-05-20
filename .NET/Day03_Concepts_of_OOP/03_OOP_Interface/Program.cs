namespace _03_OOP_Interface
{
    interface ISpellChecker
    {
        bool CheckSpelling(string word);
    }
    class EnglishSpellChecker : ISpellChecker
    {
        public bool CheckSpelling(string word)
        {
            Console.WriteLine($"EnglishSpellChecker CheckSpelling: {word}");
            return true;
        }
    }

    class FrenchSpellChecker : ISpellChecker
    {
        public bool CheckSpelling(string word)
        {
            Console.WriteLine($"FrenchSpellChecker CheckSpelling : {word}");
            return true;
        }
    }

    class Editor
    {
        private ISpellChecker _spellChecker;

        public Editor( ISpellChecker spellChecker )
        {
            this._spellChecker = spellChecker;
        }

        public void Open()
        {
            Console.WriteLine("Open");
        }
        public void Validate()
        {
            Console.WriteLine("Validate");
            if(_spellChecker != null)
            {
                _spellChecker.CheckSpelling("word"); 
            }
        }

        public void Save()
        {
            Console.WriteLine("Saving");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Editor editor = new Editor(new EnglishSpellChecker());
            editor.Open();
            editor.Validate();
            editor.Save();
            Console.WriteLine("**********************************************************");
            Editor editor1 = new Editor(new FrenchSpellChecker());
            editor1.Open();
            editor1.Validate();
            editor1.Save();
        }
    }
}