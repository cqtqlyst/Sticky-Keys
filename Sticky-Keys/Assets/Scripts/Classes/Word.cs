using System.Collections;
using System.Collections.Generic;

// a class for words
public class Word
{
    
    // fields

    public ArrayList wordArrList;
    public string wordStr;

    // constructors

    public Word() {
        wordArrList = new ArrayList();
        wordStr = "";
    }

    // methods

    public void addLetter(Letter l) {
        wordArrList.Add(l);
        wordStr += l.letter;
    }

    public void addLetter(char c) {
        wordArrList.Add(new Letter(c));
        wordStr += c;
    }

    public bool checkIsIfWord() {
        return true;
    }

}
