class Word
{
    public List<string> _BCremoved_words = new List<string>();
    public List<int> _BCremoved_indexes = new List<int>();
    public List<string> BC_word_parse(string verse)
    {
        string[] _BCarray = verse.Split(new char[] {' '} , StringSplitOptions.RemoveEmptyEntries);
        List<string> passage = new List<string>(_BCarray);
        return passage;
    }
    public List<string> BC_restore_word(List<string> _BCpassage, int _BCword_drop)
    {
        

        for (int i = 0; i < _BCword_drop; i++)
        {  
            try
            {
            int _BClast_index = _BCremoved_words.Count() - 1;
            _BCpassage[_BCremoved_indexes[_BClast_index]] = _BCremoved_words[_BClast_index];
            _BCremoved_words.RemoveAt(_BClast_index);
            _BCremoved_indexes.RemoveAt(_BClast_index);
            }
            catch (ArgumentOutOfRangeException)
            {
                return _BCpassage;
            }
        }
        return _BCpassage;
    }
    public List<string> BC_word_removal(List<string> _BCpassage, int _BCword_drop)
    {
        Random random = new Random();
        int _BCrange = _BCpassage.Count; 
        bool _BCend = true;
        string _BCword;
        int _BCrandom_word;
        List<int> _BCindexed_list = new List<int>();
        
        
        for ( int i = 0; i < _BCword_drop; i++)
           
           { do
            {
                _BCrandom_word = random.Next(0,_BCrange);
                _BCword = _BCpassage[_BCrandom_word];
                _BCend = true;

                if (_BCword.Contains("_"))
                {
                    _BCindexed_list.Add(_BCrandom_word);
                    _BCend = false;
                    if (_BCindexed_list.Count() == _BCpassage.Count())
                    {
                        return _BCpassage;
                    }
                }

                else
                {
                    _BCremoved_indexes.Add(_BCrandom_word);
                    _BCremoved_words.Add(_BCword);
                }
 
            } while(_BCend != true);

    

            string _BCblank = "";
            foreach (char letter in _BCword)  
            {      
                if (char.IsPunctuation(letter))
                {
                    _BCblank += letter;
                }
               else
                {
                    _BCblank += "_";
                }
            

            _BCpassage[_BCrandom_word] = _BCblank;
        }}
        
        return _BCpassage;
    }
    public void BC_display(List<string> _BCpassage, string _BCscripture_location)
    {
        Console.Clear();
        
        Console.WriteLine("Press space to leave.");
        Console.WriteLine("Press backspace to reveal words.");
        Console.WriteLine("Press enter to remove a word.\n");
        Console.WriteLine($"{_BCscripture_location}:");
        foreach (string word in _BCpassage)
        {
            Console.Write($"{word} ");
        }
    }   
    public int BC_get_word_drop_rate()
    {
        Console.Clear();
        bool _BCboolVar = true;
        int _BCword_drop = 1;

        do
        {
            try
            {
                Console.Write("How many words would you like to drop at a time: ");
                string input = Console.ReadLine();
                _BCword_drop = int.Parse(input);
                _BCboolVar = true;
            }
        
            catch (FormatException)
            {
                Console.WriteLine("Invalid input entered, please enter an integer.");
                _BCboolVar = false;
            }
        } while (_BCboolVar != true);
        
        return _BCword_drop;
    }
}