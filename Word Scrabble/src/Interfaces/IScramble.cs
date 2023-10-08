using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Scrabble.src.Interfaces
{
    public interface IScramble
    {
        string randomSentence(string sentence);
        string replaceWord(string word);

    }
}
