public class Letter
{
    
    // fields

    public char letter;
    private bool vowel;

    // constructors

    public Letter(char l) {

        letter = l;

        if (l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u') {
            vowel = true;
        }
        else {
            vowel = false;
        }

    }

    public Letter() {

        letter = ' ';

    }

    // methods

    public void erase() {
        letter = ' ';
    }

    public bool getVowel() {
        return vowel;
    }

}
