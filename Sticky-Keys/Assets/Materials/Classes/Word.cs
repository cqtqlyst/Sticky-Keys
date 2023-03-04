public class Word
{
    
    // fields

    public char letter;
    private bool vowel;

    // constructors

    public Word(char l) {

        letter = l;

        if (l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u') {
            vowel = true;
        }
        else {
            vowel = false;
        }

    }

    public Word() {

        letter = ' ';
        
    }

    // methods

    public erase() {
        letter = ' ';
    }


}
